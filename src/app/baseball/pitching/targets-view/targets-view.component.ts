import { Component, OnInit, Input } from '@angular/core';
import { TargetService } from '../../../services/target.service';

@Component({
  selector: 'app-targets-view',
  templateUrl: './targets-view.component.html',
  styleUrls: ['./targets-view.component.scss']
})
export class TargetsViewComponent implements OnInit {
  targetScores: { id: number, score: number }[] = [];
  @Input() isVisible: boolean;

  constructor(private targetService: TargetService) { }

  ngOnInit() {
    this.getTargetScores();
  }

  getTargetScores(){
    this.targetService.getTargetScores()
    .subscribe(it => {
      this.targetScores = it;
      console.log(this.targetScores);
    })
  }

}