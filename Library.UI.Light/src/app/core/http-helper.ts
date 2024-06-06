import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, throwError } from 'rxjs';
import { environment } from 'environments/environment';


@Injectable({ providedIn: 'root' })
export class HttpHelper {
    private _authenticated: boolean = false;
    constructor(
        private _httpClient: HttpClient,
    ) {
    }

    get(url: string): Observable<any> {
        const requestOptions = this.getHeader();
        return this._httpClient.get(url, requestOptions).pipe(
            catchError((error) => {
                // Log the error
                console.error(error);

                // Throw an error
                return throwError(() => error);
            }));
    }

    post(url: string, request: any): Observable<any> {
        const requestOptions = this.getHeader();
        return this._httpClient.post(url, request, requestOptions).pipe(
            catchError((error) => {
                // Log the error
                console.error(error);

                // Throw an error
                return throwError(() => error);
            }));
    }

    getHeader(): any {
        const accessToken = localStorage.getItem('accessToken');
        const headers = new HttpHeaders({
            'accept': '*/*',
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${accessToken}`
        });
        const requestOptions = { headers: headers };
        return requestOptions;
    }
}
