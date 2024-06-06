using KutuphaneTakipUygulaması.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakipUygulaması
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        private void btnOkuyucuEkle_Click(object sender, EventArgs e)
        {
            AddReaderForm addReaderForm = new AddReaderForm();
            addReaderForm.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
        }

        private void btnEmanetIslem_Click(object sender, EventArgs e)
        {
            LoanForm loanForm = new LoanForm();
            loanForm.Show();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

         void dataGridViewLoad()
        {
            dgEmanetler.DataSource = IDataBase.DataToDataTable("select kayitNo as [Kayıt No], kitapAdi as [Kitap Adı], yazarAdi as [Yazar Adı], yayinevi as [Yayınevi], basimYili as [Basım Yılı], sayfaSayisi as [Sayfa Sayısı], tur as [Tür] from kitaplar where aktif = 1 and durum = 0");
            dgMevcutKitaplar.DataSource = IDataBase.DataToDataTable("select kayitNo as [Kayıt No], kitapAdi as [Kitap Adı], yazarAdi as [Yazar Adı], yayinevi as [Yayınevi], basimYili as [Basım Yılı], sayfaSayisi as [Sayfa Sayısı], tur as [Tür] from kitaplar where aktif = 1 and durum = 1");
            dgOkuyucular.DataSource = IDataBase.DataToDataTable("select adi as [Adı], soyadi as [Soyadı], cinsiyeti as [Cinsiyeti], sinifi as [Sınıfı], okulNo as [Okul No], cepTel as [Cep Telefonu], adres as [Adres]  from okuyucular where aktif = 1");
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            dataGridViewLoad();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

        }
    }
}
