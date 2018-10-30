

import { Injectable } from '@angular/core';
import { Http, RequestOptions, Headers, URLSearchParams } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
import { HttpErrorResponse, HttpHeaders, HttpParams } from '@angular/common/http';
import { throwError } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { HttpParamsOptions } from '@angular/common/http/src/params';




@Injectable({
  providedIn: 'root'
})
export class ApiService {
  headers: HttpHeaders;
  token: any;
  constructor(private _httpClient: HttpClient) {
    this.headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Accept': 'q=0.8;application/json;q=0.9',
      'Cache-Control': 'no-cache',
      'Pragma': 'no-cache'

    });
  }

  get(url: string, params: HttpParamsOptions ): Observable<any> {
    const options = { params: new HttpParams(params), headers: this.headers };
    return this._httpClient.get(url, options ).catch(this.handleError)
    
     
      
  }
 
 
  post(url: string, model: any): Observable<any> {
    let body = JSON.stringify(model);
    const options = { headers: this.headers };
    return this._httpClient.post(url, body, options);
  }
  
  put(url: string, id: number, model: any): Observable<any> {
    let body = JSON.stringify(model);
    const options = { headers: this.headers };
    return this._httpClient.put(url + id, body, options);
  }

  delete(url: string, id: number): Observable<any> {
    const options = { headers: this.headers };
    return this._httpClient.delete(url + id, options);
  }
  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.error.message);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      console.error(
        `Backend returned code ${error.status}, ` +
        `body was: ${error.error}`);
    }
    // return an observable with a user-facing error message
    return throwError(
      'Something bad happened; please try again later.');
  };

}
