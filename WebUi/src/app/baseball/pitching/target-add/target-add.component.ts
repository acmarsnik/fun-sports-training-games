import { Validators, FormGroup, FormBuilder } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { TargetService } from '../../../services/target.service';
import { IScore } from 'src/app/models/score';

@Component({
  selector: 'app-target-add',
  templateUrl: './target-add.component.html',
  styleUrls: ['./target-add.component.scss'],
})
export class TargetAddComponent implements OnInit {
  inputForm: FormGroup;
  score: number;
  isVisible = false;
  showHideText = 'Show';
  targetScores: IScore[] = [];

  constructor(private fb: FormBuilder, private targetService: TargetService) {
    this.createForm();
    this.inputForm.setValue({ scoreInput: 0 });
  }

  ngOnInit() {
    this.getTargetScores();
  }

  createForm() {
    this.inputForm = this.fb.group({
      scoreInput: [
        0,
        [Validators.required, Validators.min(0), Validators.max(10)],
      ],
    });
  }

  onSubmit() {
    this.score = this.inputForm.value.scoreInput;
    this.targetService.addTarget(this.score).subscribe((it) => {
      // this.targetScores = it;
    });
  }

  showHide() {
    if (this.isVisible) {
      this.isVisible = false;
      this.showHideText = 'Show';
    } else {
      this.isVisible = true;
      this.showHideText = 'Hide';
    }
  }

  getTargetScores() {
    this.targetService.getTargetScores().subscribe((it) => {
      this.targetScores = it;
    });
  }
}
