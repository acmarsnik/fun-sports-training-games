import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { ScoresDataSource, ScoresItem } from './scores-datasource';
import { TargetService } from '../services/target.service';
import { IScore } from '../models/score';

@Component({
  selector: 'app-scores',
  templateUrl: './scores.component.html',
  styleUrls: ['./scores.component.scss'],
})
export class ScoresComponent implements AfterViewInit, OnInit {
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatTable) table: MatTable<IScore>;
  dataSource: ScoresDataSource;

  /** Columns displayed in the table. Columns IDs can be added, removed, or reordered. */
  displayedColumns = ['userId', 'value'];

  constructor(private targetService: TargetService) {
    this.dataSource = new ScoresDataSource();
  }

  ngOnInit() {
    this.getScores();
  }

  ngAfterViewInit() {
    this.refreshTable();
  }

  private refreshTable() {
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
    this.table.dataSource = this.dataSource;
  }

  getScores() {
    this.targetService.getTargetScores().subscribe(scores => {
      this.dataSource = new ScoresDataSource(scores);
      this.refreshTable();
    });
  }
}
