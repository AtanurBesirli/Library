import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable, throwError } from 'rxjs';
import { catchError, finalize } from 'rxjs/operators';
import { environment } from '../../environments/environment';
import { FuseConfirmationService } from './confirmation';


declare var $: any;

@Injectable({
    providedIn: 'root'
})
export class HttpService {



    constructor(private _http: HttpClient, private router: Router,
        private _fuseConfirmationService: FuseConfirmationService,) {

    }

    // errorCatch(error: any) {
    //     let errorMessage = error.error;
    //     //const pattern = /BaseException: (.+)/;
    //     const matches = errorMessage.match(pattern);

    //     // Eğer uygun bir eşleşme var ise, 1. grup mesajını al
    //     if (matches && matches[1]) {
    //         errorMessage = matches[1];
    //         this._fuseConfirmationService.open({
    //             message: errorMessage,
    //             title: 'HATA',
    //             actions: {
    //                 confirm: {
    //                     show: false
    //                 },
    //                 cancel: {
    //                     show: true,
    //                     label: 'OK'
    //                 }
    //             },
    //         });
    //     }

    //     else {
    //         this._fuseConfirmationService.open({
    //             message: 'Beklenmeyen Bir Hata',
    //             title: 'HATA',
    //             actions: {
    //                 confirm: {
    //                     show: false
    //                 },
    //                 cancel: {
    //                     show: true,
    //                     label: 'OK'
    //                 }
    //             },
    //         });
    //     }
    // }

}

export const enum ContentTypes {
    JSON,
    URLENCODED
}
