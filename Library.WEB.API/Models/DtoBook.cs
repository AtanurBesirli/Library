namespace Library.WEB.API.Models
{
    public class DtoBook
    {
        public int Id { get; set; } // Primary key, auto-incremented
        public int? KayitNo { get; set; } // Nullable
        public string? KitapAdi { get; set; } // Nullable
        public string? YazarAdi { get; set; } // Nullable
        public string? Yayinevi { get; set; } // Nullable
        public string? BasimYili { get; set; } // Nullable
        public string? SayfaSayisi { get; set; } // Nullable
        public string? Tur { get; set; } // Nullable
        public string? Aciklama { get; set; } // Nullable
        public string? Dolap { get; set; } // Nullable
        public string? Raf { get; set; } // Nullable
        public string? Sira { get; set; } // Nullable
        public int? Durum { get; set; } // Nullable
        public int? Aktif { get; set; } // Nullable
    }
}
