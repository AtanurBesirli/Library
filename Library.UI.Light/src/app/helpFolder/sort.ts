import { Injectable } from '@angular/core';

@Injectable()
export class Sort {
    propertyName: string; // To store the property name for sorting
    reverse: boolean; // To store the sorting direction

    /**
     * Constructor
     */
    constructor() {

        this.reverse = false;

    }

    //PropertName' e göre liste sıralama
    sortData(propertyName: string, list: any[]) {
        this.reverse = this.propertyName === propertyName ? !this.reverse : false;
        this.propertyName = propertyName;
        list = list.sort((a, b) => {
            const aValue = a[propertyName];
            const bValue = b[propertyName];
            if (aValue < bValue) return this.reverse ? 1 : -1;
            if (aValue > bValue) return this.reverse ? -1 : 1;
            return 0;
        });
    }
}
