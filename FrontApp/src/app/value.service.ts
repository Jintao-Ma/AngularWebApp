import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Item } from './domain/item';

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
  getValue (): Observable<Item[]> {
    const test = this.http.get<Item[]>(this.heroesUrl);
    return this.http.get<Item[]>(this.heroesUrl);
  }

  getItem (): Observable<Item> {
    return this.http.get<Item>('http://localhost:5000/api/values/1/');
  }

}
