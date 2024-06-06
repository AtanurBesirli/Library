import { PACKAGE_ROOT_URL, inject } from "@angular/core";
import { ActivatedRouteSnapshot, Router, RouterStateSnapshot, Routes } from "@angular/router";
import { BookListComponent } from "./book-list.component";



/**
 * Task resolver
 *
 * @param route
 * @param state
 */

/**
 * Can deactivate tasks details
 *
 * @param component
 * @param currentRoute
 * @param currentState
 * @param nextState
 */


export default [
    {
        path: 'book-list',
        component: BookListComponent,
        resolve: {


        },

    },

   




    { path: "**", pathMatch: "full", redirectTo: "" },
] as Routes;
