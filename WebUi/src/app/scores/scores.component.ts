import { Component, HostListener, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { ScoresDataSource } from './scores-datasource';
import { TargetService } from '../services/target.service';
import { IScore, IBaseScore } from '../models/score';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-scores',
  templateUrl: './scores.component.html',
  styleUrls: ['./scores.component.scss'],
})
export class ScoresComponent implements OnInit {
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatTable) table: MatTable<IScore>;
  inputForm: FormGroup;

  public dataSource: ScoresDataSource;

  /** Columns displayed in the table. Columns IDs can be added, removed, or reordered. */
  public displayedColumns = ['userId', 'value'];

  public scoresCols: number;

  public rowHeight: number;
  public rowHeightString: string;
  public minRows: number;

  public enterScoreRowSpan: number;
  public enterScoreColSpan: number;

  public scoreHistoryColSpan: number;
  public scoreHistoryRowSpan: number;

  public defaultPageIndex: number;
  public defaultPageSize: number;
  public defaultPageSizeOptions: number[];
  public innerWidth: any;

  constructor(
    private formBuilder: FormBuilder,
    private targetService: TargetService
  ) {
    this.setDefaultScoresData();
    this.createForm();
    this.inputForm.setValue({ scoreValue: 0, userId: 1 });
  }

  @HostListener('window:resize', ['$event'])
  onResize() {
    this.innerWidth = window.innerWidth;
    this.setColSpans();
  }

  ngOnInit() {
    this.getScores();
    this.innerWidth = window.innerWidth;
    this.setColSpans();
  }

  public pageEventReceiver(pageEvent: PageEvent) {
    this.defaultPageSize = pageEvent?.pageSize;
    this.refreshTable(pageEvent);
  }

  public onSubmit() {
    const scoreToAdd: IBaseScore = {
      value: this.inputForm.value.scoreValue,
      userId: this.inputForm.value.userId,
    };
    this.targetService.addScore(scoreToAdd).subscribe(() => {
      this.getScores();
    });
  }

  private createForm() {
    this.inputForm = this.formBuilder.group({
      scoreValue: [
        0,
        [Validators.required, Validators.min(0), Validators.max(10)],
      ],
      userId: [1, [Validators.required, Validators.min(1)]],
    });
  }

  private setDefaultScoresData() {
    this.dataSource = new ScoresDataSource();
    this.scoresCols = 3;

    this.rowHeight = 3.125;
    this.rowHeightString = `${this.rowHeight}rem`;
    this.minRows = 5;

    this.enterScoreRowSpan = this.minRows;
    this.enterScoreColSpan = 3;

    this.scoreHistoryColSpan = 3;
    this.scoreHistoryRowSpan = this.minRows;

    this.defaultPageIndex = 0;
    this.defaultPageSize = 5;
    this.defaultPageSizeOptions = [5, 10, 25, 50, 100, 250];

    this.setScoreHistoryRowSpan();
  }

  private setScoreHistoryRowSpan(
    currentNumberOfItemsDisplayed: number = this.getCurrentNumberOfItemsDisplayed(),
    minRows: number = this.minRows
  ) {
    this.scoreHistoryRowSpan = currentNumberOfItemsDisplayed + minRows;
  }

  private getCurrentNumberOfItemsDisplayed(
    pageEvent: PageEvent = null
  ): number {
    let currentNumberOfItemsDisplayed = 0;

    if (pageEvent) {
      const numberOfPages: number = Math.ceil(
        pageEvent.length / pageEvent.pageSize
      );
      const currentPageNumber: number = pageEvent.pageIndex + 1;
      currentNumberOfItemsDisplayed = pageEvent.pageSize;
      const isLastPage: boolean = numberOfPages === currentPageNumber;

      if (isLastPage) {
        currentNumberOfItemsDisplayed = pageEvent.length % pageEvent.pageSize;
        if (currentNumberOfItemsDisplayed === 0) {
          currentNumberOfItemsDisplayed = pageEvent.pageSize;
        }
      }
    }

    return currentNumberOfItemsDisplayed;
  }

  private refreshTable(
    pageEvent: PageEvent = {
      pageIndex: this.defaultPageIndex,
      pageSize: this.defaultPageSize,
      previousPageIndex: this.defaultPageIndex,
      length: this.dataSource?.data.length,
    }
  ) {
    if (this.dataSource) {
      this.dataSource.sort = this.sort;
      this.dataSource.paginator = this.paginator;

      if (this.table) {
        this.table.dataSource = this.dataSource;
      }

      this.setScoreHistoryRowSpan(
        this.getCurrentNumberOfItemsDisplayed(pageEvent)
      );
    }
  }

  private getScores() {
    this.targetService.getAllScores().subscribe(scores => {
      this.dataSource = new ScoresDataSource(scores);
      this.refreshTable();
    });
  }

  private setColSpans() {
    if (this.innerWidth > 768) {
      this.enterScoreColSpan = 1;
      this.scoreHistoryColSpan = 2;
    } else {
      this.enterScoreColSpan = 3;
      this.scoreHistoryColSpan = 3;
    }
  }
}
