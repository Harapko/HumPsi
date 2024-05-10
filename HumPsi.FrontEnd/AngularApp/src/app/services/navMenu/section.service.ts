import { Injectable } from '@angular/core';
import {Section} from "../../models/navMenu/section";
import {HttpClient} from "@angular/common/http"
import {Observable} from "rxjs"

@Injectable({
  providedIn: 'root'
})
export class SectionService {
  sections: Section[] = []

  constructor(private httpClient: HttpClient) { }

  public getSection(): Observable<Section[]>{
    return this.httpClient.get<Section[]>("http://localhost:5198/home")
  }
}
