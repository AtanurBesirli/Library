using KutuphaneTakipUygulaması.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakipUygulaması
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            if (IDataBase.DataToDataTable("select * from kullanicilar where aktif = 1").Rows.Count > 0)
            {
                Application.Run(new LoginForm());
            }
            else
            {
                Application.Run(new KurulumFormu());
            }
        }
    }
}
