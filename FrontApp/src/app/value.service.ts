import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ValueService {
  private heroesUrl = 'http://localhost:5000/api/values/';  // URL to web api
  constructor(private http: HttpClient) { }

  // getValue(): string {
  //   return 'value1';
  // }

  /** GET heroes from the server */
  getValue (): Observable<string> {
    const test = this.http.get<string>(this.heroesUrl);
    return this.http.get<string>(this.heroesUrl);
  }

}
