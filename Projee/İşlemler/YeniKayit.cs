using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee.İşlemler
{
    public class YeniKayit
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Mail { get; set; }


        public string TelNo { get; set; }
        public string Sifre { get; set; }

        public YeniKayit(string _telNo, string _sifre)
        {
            TelNo = _telNo;
            Sifre = _sifre;
        }
        public YeniKayit(string _isim, string _soyisim, string _mail, string _telNo, string _sifre)
        {
            Isim = _isim;
            Soyisim = _soyisim;
            Mail = _mail;
            TelNo = _telNo;
            Sifre = _sifre;
        }
    }
}