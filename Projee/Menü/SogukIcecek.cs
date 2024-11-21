using Projee.Giriş_Sayfası;
using Projee.İşlemler;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projee.Menü
{
    public partial class SogukIcecek : Form, INumericUpDownIslemleri, IFisGoster, IToplamFiyat
    {
        public decimal toplamFiyat;
        private AnaSayfa AnaSayfa;
        public string sonuc;
        public List<NumericUpDown> NudSogukIcecekMiktari;
        public Dictionary<string, decimal> IcecekIsimFiyat;
        public SogukIcecek(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            AnaSayfa = anaSayfa;
            NudSogukIcecekMiktari = new List<NumericUpDown>()
            {
                nudSoda,
                nudFro,
                nudBubbleTea,
                nudLimon,
                nudMilkshake,
                nudChurc,
                nudKola,
                nudMeyveSuyu,
            };

            NudDegerDegistirme(NudSogukIcecekMiktari, Numericupdown_ValueChanged);

            IcecekIsimFiyat = new Dictionary<string, decimal>()
            {
                {"soda",35},
                {"Frozen",60},
                {"Bubble Tea",70},
                {"Limonata",50},
                {"Milkshake",80},
                {"Churcill",50},
                {"Kola",35},
                {"Meyve Suyu",25},
            };
            NudTagAtama(NudSogukIcecekMiktari, IcecekIsimFiyat);
        }
        public void Numericupdown_ValueChanged(object sender, EventArgs e)
        {
            //AnaSayfa anaSayfa = new AnaSayfa();
            decimal toplamFiyat = Ucret(NudSogukIcecekMiktari, IcecekIsimFiyat);
            AnaSayfa.FisiGoster(FisGoster(NudSogukIcecekMiktari, IcecekIsimFiyat));
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
            sonuc = goster.FisGoster(NudSogukIcecekMiktari, IcecekIsimFiyat);
            return goster.FisGoster(NudSogukIcecekMiktari, IcecekIsimFiyat);
        }

        public decimal Ucret(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            ToplamFiyatHesaplayici toplamFiyatHesaplayici = new ToplamFiyatHesaplayici();
            toplamFiyat = toplamFiyatHesaplayici.Ucret(NudSogukIcecekMiktari, IcecekIsimFiyat);
            return toplamFiyat;
        }
    }
}