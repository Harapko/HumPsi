import { Injectable } from '@angular/core';
import {ApiService} from "../api.service";
import {Observable} from "rxjs";
import {Headlines} from "../../../types";



@Injectable({
  providedIn: 'root'
})
export class HeadlinesService {

  constructor(private apiService: ApiService) { }

  getHeadlines = (url: string) : Observable<Headlines[]> => {
    return this.apiService.get(url);
  }

  createHeadlines = (url: string, body: any): Observable<any> =>{
    return this.apiService.post(url, body, {});
  }

  editHeadline = (url: string, body: any): Observable<any> => {
    return this.apiService.put(url, body);
  }

  deleteHeadline = (url: string): Observable<any> => {
    return this.apiService.delete(url);
  }
}
