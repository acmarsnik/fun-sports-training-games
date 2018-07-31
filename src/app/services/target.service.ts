import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TargetService {
  target_scores: number[] = [0, 1];

  constructor(private http: HttpClient) { }

  addTarget(target_score: number){
    this.target_scores.push(target_score);
    console.log(this.target_scores);
  }

  deleteTarget(index: number){
    this.target_scores.splice(index, 1);
  }

  getTargets(){
    return this.target_scores;
  }

  getTargetScores(): Observable<{ id: number, score: number }[]> {
    const url = 'api/targetScores';
    return this.http.get<{ id: number, score: number }[]>(url)
    .pipe(
    );
  }

}
