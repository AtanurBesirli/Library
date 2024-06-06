export interface IBook {
    id: number;                 // Primary key, auto-incremented
    kayitNo?: number;           // Optional
    kitapAdi?: string;          // Optional
    yazarAdi?: string;          // Optional
    yayinevi?: string;          // Optional
    basimYili?: string;         // Optional
    sayfaSayisi?: string;       // Optional
    tur?: string;               // Optional
    aciklama?: string;          // Optional
    dolap?: string;             // Optional
    raf?: string;               // Optional
    sira?: string;              // Optional
    durum?: number;             // Optional
    aktif?: number;

}