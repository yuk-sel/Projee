using Projee.Giriş_Sayfası;
using Projee.İşlemler;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projee.Menü
{
    public partial class SutluTatli : Form, INumericUpDownIslemleri, IFisGoster, IToplamFiyat
    {
        public decimal toplamFiyat;
        private AnaSayfa AnaSayfa;
        public string sonuc;
        public List<NumericUpDown> NudSutluTatlikMiktari;
        public Dictionary<string, decimal> SutluTatliIsimFiyat;
        public SutluTatli(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            AnaSayfa = anaSayfa;
            NudSutluTatlikMiktari = new List<NumericUpDown>()
            {
                nudTavukG,
                nudFirirnS,
                nudTiramisu,
                nudTrileçe,
                nudProfiterol,
                nudKlasikM,
                nudPuding,
                nudSupangle,
            };

            NudDegerDegistirme(NudSutluTatlikMiktari, Numericupdown_ValueChanged);

            SutluTatliIsimFiyat = new Dictionary<string, decimal>()
            {
                {"Tavuk Göğsü",65},
                {"Fırın Sütlaç",55},
                {"Tiramisu",60},
                {"Trileçe",60},
                {"Profiterol",35},
                {"Klasik Muhallebbi",50},
                {"Puding",40},
                {"Supangle",45},
            };
            NudTagAtama(NudSutluTatlikMiktari, SutluTatliIsimFiyat);
        }
        public void Numericupdown_ValueChanged(object sender, EventArgs e)
        {
            //AnaSayfa anaSayfa = new AnaSayfa();
            decimal toplamFiyat = Ucret(NudSutluTatlikMiktari, SutluTatliIsimFiyat);
            AnaSayfa.FisiGoster(FisGoster(NudSutluTatlikMiktari, SutluTatliIsimFiyat));
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
            sonuc = goster.FisGoster(NudSutluTatlikMiktari, SutluTatliIsimFiyat);
            return goster.FisGoster(NudSutluTatlikMiktari, SutluTatliIsimFiyat);
        }

        public decimal Ucret(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            ToplamFiyatHesaplayici toplamFiyatHesaplayici = new ToplamFiyatHesaplayici();
            toplamFiyat = toplamFiyatHesaplayici.Ucret(NudSutluTatlikMiktari, SutluTatliIsimFiyat);
            return toplamFiyat;
        }
    }
}