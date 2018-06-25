import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Item } from './domain/item';

@Injectable({
  providedIn: 'root'
})
export class ValueService {
  private baseUrl = 'http://localhost:5000/api/values/';  // URL to web api
  constructor(private http: HttpClient) { }

  // getValue(): string {
  //   return 'value1';
  // }

  /** GET heroes from the server */
  getAll (): Observable<Item[]> {
    const test = this.http.get<Item[]>(this.baseUrl);
    return this.http.get<Item[]>(this.baseUrl);
  }

  getItem (id: number): Observable<Item> {
    return this.http.get<Item>(this.baseUrl + id.toString());
  }

  deleteItem(id: number) {
    return this.http.delete(this.baseUrl + id.toString());
  }

  updateItem(id: number, item: Item): Observable<Item> {
    return this.http.put<Item>(this.baseUrl + id.toString(), item);
  }

}
