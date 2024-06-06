using Library.WEB.API.Models;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;

namespace Library.WEB.API.Service
{
    public interface ILibraryService
    {
        Task<List<DtoBook>> GetBookList();
    }


    public class LibraryService: ILibraryService
    {
        public async Task<List<DtoBook>> GetBookList()
        {
            List<DtoBook> dtoBooks = new List<DtoBook>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            DataTable dt = IDataBase.DataToDataTable("select * from kitaplar", parameters);

            foreach (DataRow row in dt.Rows)
            {
                DtoBook dtoBook = new DtoBook();
                dtoBook.Id = Convert.ToInt32(row["id"]);
                dtoBook.KayitNo = Convert.ToInt32(row["kayitNo"]);
                dtoBook.KitapAdi = row["kitapAdi"].ToString();
                dtoBook.YazarAdi = row["yazarAdi"].ToString();
                dtoBook.Yayinevi = row["yayinevi"].ToString();
                dtoBook.BasimYili = row["basimYili"].ToString();
                dtoBook.SayfaSayisi = row["sayfaSayisi"].ToString();
                dtoBook.Tur = row["tur"].ToString();
                dtoBook.Aciklama = row["aciklama"].ToString();
                dtoBook.Dolap = row["dolap"].ToString();
                dtoBook.Raf = row["raf"].ToString();
                dtoBook.Sira = row["sira"].ToString();
                //dtoBook.kategori = row["kategori"].ToString();
                dtoBook.Durum = Convert.ToInt32(row["durum"]);
                dtoBook.Aktif = Convert.ToInt32(row["aktif"]);
                dtoBooks.Add(dtoBook);
            }
            return dtoBooks;
        }
    }
}
