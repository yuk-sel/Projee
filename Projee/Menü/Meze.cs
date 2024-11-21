using Projee.Giriş_Sayfası;
using Projee.İşlemler;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projee.Menü
{
    public partial class Meze : Form, INumericUpDownIslemleri, IFisGoster, IToplamFiyat
    {
        public decimal toplamFiyat;
        private AnaSayfa AnaSayfa;
        public string sonuc;
        public List<NumericUpDown> NudMezeMiktari;
        public Dictionary<string, decimal> MezeIsimFiyat;
        public Meze(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            AnaSayfa = anaSayfa;
            NudMezeMiktari = new List<NumericUpDown>()
            {
                nudHumus,
                nudÇigKofte,
                nudAciliEzme,
                nudHaydari,
                nudKekik,
                nudCevizliHavucTarator,
                nudBabagannus,
                nudDenizBorulcesi,
            };

            NudDegerDegistirme(NudMezeMiktari, Numericupdown_ValueChanged);

            MezeIsimFiyat = new Dictionary<string, decimal>()
            {
                {"Humus",75},
                {"Çiğ Köfte",75},
                {"Acılı Ezme",75},
                {"Haydari",100},
                {"Kekik Salatası(Zahter)",90},
                {"Cevizli Havuç Tarator",85},
                {"Babagannus",75},
                {"Deniz Börülcesi",120},
            };
            NudTagAtama(NudMezeMiktari, MezeIsimFiyat);
        }
        public void Numericupdown_ValueChanged(object sender, EventArgs e)
        {
            //AnaSayfa anaSayfa = new AnaSayfa();
            decimal toplamFiyat = Ucret(NudMezeMiktari, MezeIsimFiyat);
            AnaSayfa.FisiGoster(FisGoster(NudMezeMiktari, MezeIsimFiyat));
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
            sonuc = goster.FisGoster(NudMezeMiktari, MezeIsimFiyat);
            return goster.FisGoster(NudMezeMiktari, MezeIsimFiyat);
        }

        public decimal Ucret(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            ToplamFiyatHesaplayici toplamFiyatHesaplayici = new ToplamFiyatHesaplayici();
            toplamFiyat = toplamFiyatHesaplayici.Ucret(NudMezeMiktari, MezeIsimFiyat);
            return toplamFiyat;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}