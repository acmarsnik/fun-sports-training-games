import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { IScore } from '../models/score';

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

  addTarget(target_score: number) {
    console.log(target_score);
    console.log(this.scoreUrl);
    const data = { UserId: 1, Value: target_score };
    return this.http.post(this.scoreUrl, data, options).pipe();
  }

  deleteTarget(index: number) {
    this.target_scores.splice(index, 1);
  }

  getTargets() {
    return this.target_scores;
  }

  /* getTargetScores(): Observable<{ id: number, score: number }[]> {
    const url = 'api/targetScores';
    return this.http.get<{ id: number, score: number }[]>(url)
    .pipe(
    );
  } */

  getTargetScores(): Observable<IScore[]> {
    return this.http.get<IScore[]>(this.allScoresUrl).pipe();
  }
}
