using Projee.Giriş_Sayfası;
using Projee.İşlemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee.Menü
{

    public partial class Salata : Form, INumericUpDownIslemleri, IFisGoster, IToplamFiyat
    {
        public decimal toplamFiyat;
        public string sonuc;
        private AnaSayfa AnaSayfa;
        public List<NumericUpDown> NudSalataMiktari;
        public Dictionary<string, decimal> SalataIsimFiyat;

        public Salata(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            AnaSayfa = anaSayfa;
            NudSalataMiktari = new List<NumericUpDown>()
            {
                nudSezar,
                nudCitirTavuk,
                nudPatataes,
                nudKirmizi,
                nudGavurdag,
                nudTonBalik,
                nudRus,
                nudNicoise,
            };

            NudDegerDegistirme(NudSalataMiktari, Numericupdown_ValueChanged);

            SalataIsimFiyat = new Dictionary<string, decimal>()
            {
                {"Sezar Salata",105},
                {"Çıtır Tavuklu Salata",125},
                {"Patates Salata",90},
                {"Kırmzı Lahana Salata",80},
                {"Gavurdağı Salata",85},
                {"Ton Balıklı Salata",145},
                {"Rus Salatas",90},
                {"Nicoise Salata",110},
            };
            NudTagAtama(NudSalataMiktari, SalataIsimFiyat);

        }

        public void Numericupdown_ValueChanged(object sender, EventArgs e)
        {
            // AnaSayfa anaSayfa = new AnaSayfa();
            decimal toplamFiyat = Ucret(NudSalataMiktari, SalataIsimFiyat);
            AnaSayfa.FisiGoster(FisGoster(NudSalataMiktari, SalataIsimFiyat));

        }

        public void NudDegerDegistirme(List<NumericUpDown> miktar, EventHandler handler)
        {
            TagAtama tagatama = new TagAtama();
            tagatama.NudDegerDegistirme(miktar, handler);
        }

        public void NudTagAtama(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            TagAtama tagatama = new TagAtama();
            tagatama.NudTagAtama(miktar, fiyat);
        }

        public string FisGoster(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            Goster goster = new Goster();
            sonuc = goster.FisGoster(NudSalataMiktari, SalataIsimFiyat);
            return goster.FisGoster(NudSalataMiktari, SalataIsimFiyat);
        }

        public decimal Ucret(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            ToplamFiyatHesaplayici toplamFiyatHesaplayici = new ToplamFiyatHesaplayici();
            toplamFiyat = toplamFiyatHesaplayici.Ucret(NudSalataMiktari, SalataIsimFiyat);
            return toplamFiyat;
        }
        private void CARPI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}