import { Injectable, WritableSignal, signal } from '@angular/core';
import { IsActiveMatchOptions } from '@angular/router';
import { HttpService } from '@fuse/services/http.service';
import { HttpHelper } from 'app/core/http-helper';
import { IBook } from 'app/models/IBook';
import { environment } from 'environments/environment';
import { BehaviorSubject, Observable, catchError, of, shareReplay, switchMap, take, tap, throwError } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class LibraryService {
   
   
    //Connection EndPoints
     libraryApiUrl = environment.apiUrl + environment.endpoints.library;


    constructor(private _httpHelper: HttpHelper, private _httpClient: HttpHelper, private _httpService: HttpService) { }


    
    //Book List
    getBookList(): Observable<IBook[]> {
        return this._httpHelper.get(this.libraryApiUrl + "/GetBookList" ).pipe(
            tap((response: IBook[]) => {

            }),
            catchError((error) => {
                //this._httpService.errorCatch(error);
                return throwError(error);
            })
        );
    }

   

}
