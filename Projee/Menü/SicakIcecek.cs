using Projee.Giriş_Sayfası;
using Projee.İşlemler;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projee.Menü
{
    public partial class SicakIcecek : Form, INumericUpDownIslemleri, IFisGoster, IToplamFiyat
    {
        public decimal toplamFiyat;
        private AnaSayfa AnaSayfa;
        public string sonuc;
        public List<NumericUpDown> NudSicakIcecekMiktari;
        public Dictionary<string, decimal> IcecekIsimFiyat;
        public SicakIcecek(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            AnaSayfa = anaSayfa;
            NudSicakIcecekMiktari = new List<NumericUpDown>()
            {
                nudKahve,
                nudCay,
                nudCappucino,
                nudOralet,
                nudYesil,
                nudCikolata,
                nudEspresso,
                nudFiltreKahve,
            };

            NudDegerDegistirme(NudSicakIcecekMiktari, Numericupdown_ValueChanged);

            IcecekIsimFiyat = new Dictionary<string, decimal>()
            {
                {"Türk Kahvesi",50},
                {"Çay",15},
                {"Cappucino",60},
                {"Oralet",40},
                {"Yeşil Çay",50},
                {"Sıcak Çikolata",50},
                {"Espresso",60},
                {"Filtre Kahve",55},
            };
            NudTagAtama(NudSicakIcecekMiktari, IcecekIsimFiyat);
        }
        public void Numericupdown_ValueChanged(object sender, EventArgs e)
        {
            //AnaSayfa anaSayfa = new AnaSayfa();
            decimal toplamFiyat = Ucret(NudSicakIcecekMiktari, IcecekIsimFiyat);
            AnaSayfa.FisiGoster(FisGoster(NudSicakIcecekMiktari, IcecekIsimFiyat));
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
            sonuc = goster.FisGoster(NudSicakIcecekMiktari, IcecekIsimFiyat);
            return goster.FisGoster(NudSicakIcecekMiktari, IcecekIsimFiyat);
        }

        public decimal Ucret(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            ToplamFiyatHesaplayici toplamFiyatHesaplayici = new ToplamFiyatHesaplayici();
            toplamFiyat = toplamFiyatHesaplayici.Ucret(NudSicakIcecekMiktari, IcecekIsimFiyat);
            return toplamFiyat;
        }
    }
}