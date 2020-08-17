import { Component, OnInit, Input } from '@angular/core';
import { IScore } from 'src/app/models/score';

@Component({
  selector: 'app-targets-view',
  templateUrl: './targets-view.component.html',
  styleUrls: ['./targets-view.component.scss'],
})
export class TargetsViewComponent implements OnInit {
  @Input() targetScores: IScore[];
  @Input() isVisible: boolean;

  constructor() {}

  ngOnInit() {}
}
