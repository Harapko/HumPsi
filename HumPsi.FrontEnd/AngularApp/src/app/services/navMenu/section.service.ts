import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http"
import {Observable} from "rxjs"


export interface SectionsModel {
  id: string;
  titleSection: string;
  headlinesList: [string]
}

@Injectable({
  providedIn: 'root'
})
export class SectionService {

  constructor(private httpClient: HttpClient) { }

  public getSection(): Observable<SectionsModel[]>{
    return this.httpClient.get<SectionsModel[]>("http://localhost:5198/home")
  }
}
