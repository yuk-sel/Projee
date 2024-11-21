using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee
{
    internal static class Program
    {
        private static string _telNo = "12345678911";
        private static string _sifre = "123456";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GirisEkrani(new İşlemler.YeniKayit(_telNo, _sifre)));
        }
    }
}