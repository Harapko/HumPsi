import { Injectable } from '@angular/core';
import {Observable} from "rxjs"
import {ApiService} from "../api.service";
import {Section} from "../../../types";

@Injectable({
  providedIn: 'root'
})
export class SectionService {

  constructor(private apiService: ApiService) { }

  getSection = (url: string): Observable<Section[]> =>{
    return this.apiService.get(url);
  }
}
