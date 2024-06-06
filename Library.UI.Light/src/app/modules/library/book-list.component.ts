import { CdkScrollable } from '@angular/cdk/scrolling';
import { DatePipe, I18nPluralPipe, NgClass, NgFor, NgIf, PercentPipe } from '@angular/common';
import { ChangeDetectionStrategy, ChangeDetectorRef, Component, ElementRef, OnDestroy, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatOptionModule } from '@angular/material/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatSelect, MatSelectChange, MatSelectModule } from '@angular/material/select';
import { MatSlideToggleChange, MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatTooltipModule } from '@angular/material/tooltip';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { FuseFindByKeyPipe } from '@fuse/pipes/find-by-key/find-by-key.pipe';
import { BehaviorSubject, combineLatest, Subject, takeUntil } from 'rxjs';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { IBook } from 'app/models/IBook';
import { LibraryService } from './library.service';
import { FuseConfirmationService } from '@fuse/services/confirmation';
import { FuseAlertService } from '@fuse/components/alert';

@Component({
    selector: 'book-list',
    templateUrl: './book-list.component.html',
    encapsulation: ViewEncapsulation.None,
    changeDetection: ChangeDetectionStrategy.OnPush,
    standalone: true,
    imports: [CdkScrollable, MatFormFieldModule, MatSelectModule, MatOptionModule, NgFor, MatIconModule, MatInputModule, MatSlideToggleModule, NgIf, NgClass, MatTooltipModule, MatProgressBarModule, MatAutocompleteModule, MatButtonModule, RouterLink, FuseFindByKeyPipe, PercentPipe, I18nPluralPipe, DatePipe, MatInputModule],
})
export class BookListComponent implements OnInit, OnDestroy {


    @ViewChild('query') query: ElementRef;
    bookList: IBook[] = [];
    filteredBook: IBook[] = [];
    filters: {
        query$: BehaviorSubject<string>
    } = {
            query$: new BehaviorSubject('')

        };

    private _unsubscribeAll: Subject<any> = new Subject<any>();

    /**
     * Constructor
     */
    constructor(
        private _activatedRoute: ActivatedRoute,
        private _changeDetectorRef: ChangeDetectorRef,
        private _router: Router,
        private _libraryService: LibraryService,
        private _fuseConfirmationService: FuseConfirmationService,
        private _fuseDialog: FuseAlertService
    ) {
    }

    // -----------------------------------------------------------------------------------------------------
    // @ Lifecycle hooks
    // -----------------------------------------------------------------------------------------------------

    /**
     * On init
     */
    ngOnInit(): void {
        // Get the Book List

        this._libraryService.getBookList().subscribe(data => {
            this.bookList = data;
            this.filteredBook = this.bookList;
            // Mark for check
            this._changeDetectorRef.markForCheck();
        });



        // Filter the Book
        combineLatest([this.filters.query$])
            .subscribe(([query]) => {
                // Reset the filtered courses
                this.filteredBook = this.bookList;

                // Filter by search query
                if (query !== '') {
                    this.filteredBook = this.filteredBook.filter(book => {
                        const matchesQuery = query ? book.kitapAdi.toLowerCase().includes(query.toLowerCase()) : true;
                        const matchesAuthor = query ? book.yazarAdi.toLowerCase().includes(query.toLowerCase()) : true;
                        const matchesPublisher = query ? book.yayinevi.toString() === (query.toLowerCase()) : true;

                        // Tüm kriterleri karşılayan kitapları döndür
                        return matchesQuery && matchesAuthor && matchesPublisher;
                    });
                }
            });
    }

    /**
     * On destroy
     */
    ngOnDestroy(): void {
        // Unsubscribe from all subscriptions
        this._unsubscribeAll.next(null);
        this._unsubscribeAll.complete();
    }


    // -----------------------------------------------------------------------------------------------------
    // @ Public methods
    // -----------------------------------------------------------------------------------------------------

    /**
     * Filter by search query
     *
     * @param query
     */
    filterByQuery(query: string): void {
        this.filters.query$.next(query);
    }


    /**
     * Show/hide completed courses
     *
     * @param change
     */


    /**
     * Track by function for ngFor loops
     *
     * @param index
     * @param item
     */
    trackByFn(index: number, item: any): any {
        return item.id || index;
    }

    reservation(book?: IBook) {
        // Open the confirmation dialog
        const confirmation = this._fuseConfirmationService.open({
            title: 'Kitap Rezerve Etme',
            message: book.kitapAdi + "isimli kitap rezerve edilecekir , emin misiniz ?",
            actions: {
                cancel: {
                    label: "Vazgeç",
                },
                confirm: {
                    label: 'Rezerve Et',
                },
            },
        });

        // Subscribe to the confirmation dialog closed action
        confirmation.afterClosed().subscribe((result) => {
            // If the confirm button pressed...
            if (result === 'confirmed') {
                this._fuseDialog.show("Rezerve Edildi");



            }
        });

    }


    filterClear() {
        this.filteredBook = this.bookList;
        this.filteredBook = this.bookList;
        this.query.nativeElement.value = '';
        this.filters.query$.next('');
    }
}
