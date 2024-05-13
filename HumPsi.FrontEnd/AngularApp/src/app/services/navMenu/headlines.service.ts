import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";

export interface HeadlinesModel {
  id: string,
  title: string,
  sectionId: string,
  photoId: string,
  articles: [any]

}

@Injectable({
  providedIn: 'root'
})
export class HeadlinesService {

  constructor(private httpClient: HttpClient) { }

  createHeadline(){

  }
}
