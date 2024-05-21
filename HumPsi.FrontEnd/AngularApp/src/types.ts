import {HttpContext, HttpHeaders, HttpParams} from "@angular/common/http";

export interface Options{
  headers?: HttpHeaders | {
    [header: string]: string | string[];
  };
  observe?: 'body';
  context?: HttpContext;
  params?: HttpParams | {
    [param: string]: string | number | boolean | ReadonlyArray<string | number | boolean>;
  };
  reportProgress?: boolean;
  responseType?: 'json';
  withCredentials?: boolean;
  transferCache?: {
    includeHeaders?: string[];
  } | boolean;
}


export interface Section{
  id: string;
  titleSection: string;
}

export interface Headlines{
  id: string,
  title: string,
  sectionId: string | null,
  photo: string,

}


