import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

const options = {headers: new HttpHeaders({'Content-Type': 'application/json' })};
@Injectable({
  providedIn: 'root'
})
export class TargetService {
  target_scores: number[] = [0, 1];

  constructor(private http: HttpClient) { }

  addTarget(target_score: number){
    const url = 'api/targetScores';
    return this.http.post<{ id: number, score: number }[]>(url, target_score, options)
    .pipe();
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
