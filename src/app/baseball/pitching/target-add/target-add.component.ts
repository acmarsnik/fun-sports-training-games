import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators } from "@angular/forms";
import { TargetService } from '../../../services/target.service';

@Component({
  selector: 'app-target-add',
  templateUrl: './target-add.component.html',
  styleUrls: ['./target-add.component.scss']
})
export class TargetAddComponent implements OnInit {
  
  inputForm: FormGroup;
  score: number;
  isVisible: boolean = false;
  showHideText: string = 'Show';

  constructor(private fb: FormBuilder, private TargetService: TargetService) {
    this.createForm();
    this.inputForm.setValue({scoreInput: 0})
  }

  ngOnInit() {
  }

  createForm() {
    this.inputForm = this.fb.group({
      scoreInput: [0, [Validators.required, Validators.min(0), Validators.max(10)]]
    });
  }

  onSubmit(){
    this.score = this.inputForm.value.scoreInput;
    this.TargetService.addTarget(this.score);
    
  }

  showHide(){
    if(this.isVisible){
      this.isVisible = false;
      this.showHideText = 'Show'
    }
    else{
      this.isVisible = true;
      this.showHideText = 'Hide'
    }
  }

}
