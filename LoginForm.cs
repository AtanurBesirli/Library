using KutuphaneTakipUygulaması.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakipUygulaması
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //private void txtBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void btnGiris_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@kullaniciAdi", SqlDbType.VarChar) { Value = txtKullaniciAdi.Text });
            parameters.Add(new SqlParameter("@sifre", SqlDbType.VarChar) { Value = txtSifre.Text });

            DataTable dt = IDataBase.DataToDataTable("select * from kullanicilar where aktif = 1 and kullaniciAdi = @kullaniciAdi and sifre = @sifre", parameters);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    UserInfo.userId = Convert.ToInt32(row["id"]);
                }

                MainForm mainForm = new MainForm();
                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı!");
            }
        }
    }
}
