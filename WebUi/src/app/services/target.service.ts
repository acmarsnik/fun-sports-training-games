import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { IScore, IBaseScore } from '../models/score';

const options = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
};
@Injectable({
  providedIn: 'root',
})
export class TargetService {
  target_scores: number[] = [0, 1];
  scoreUrl = environment.scoreUrl;
  allScoresUrl = environment.allScoresUrl;

  constructor(private http: HttpClient) {}

  addScore(score: IBaseScore): Observable<IScore> {
    return this.http.post<IScore>(this.scoreUrl, score, options).pipe();
  }

  deleteScore(index: number) {
    this.target_scores.splice(index, 1);
  }

  getScore() {
    return this.target_scores;
  }

  getAllScores(): Observable<IScore[]> {
    return this.http.get<IScore[]>(this.allScoresUrl).pipe();
  }
}
