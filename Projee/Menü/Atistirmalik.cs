using Projee.Giriş_Sayfası;
using Projee.İşlemler;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projee.Menü
{
    public partial class Atistirmalik : Form, INumericUpDownIslemleri, IFisGoster, IToplamFiyat
    {
        public decimal toplamFiyat;
        private AnaSayfa AnaSayfa;
        public string sonuc;
        public List<NumericUpDown> NudAtistirmalikMiktari;
        public Dictionary<string, decimal> AtistirmalikIsimFiyat;
        public Atistirmalik(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            AnaSayfa = anaSayfa;
            NudAtistirmalikMiktari = new List<NumericUpDown>()
            {
                nudTost,
                nudMenemen,
                nudPatatesT,
                nudCitir,
                nudSoganH,
                nudSosis,
                nudSigara,
                nudMısır,
            };

            NudDegerDegistirme(NudAtistirmalikMiktari, Numericupdown_ValueChanged);

            AtistirmalikIsimFiyat = new Dictionary<string, decimal>()
            {
                {"Tost",80},
                {"Menemen",110 },
                {"Patates Tava",130},
                {"Çıtır Tavuk",160},
                {"Soğan Halkası",100},
                {"Sosisli",100},
                {"Sigara Böreği",100},
                {"Patlamış Mısır",90},
            };
            NudTagAtama(NudAtistirmalikMiktari, AtistirmalikIsimFiyat);
        }
        public void Numericupdown_ValueChanged(object sender, EventArgs e)
        {
            //AnaSayfa anaSayfa = new AnaSayfa();
            decimal toplamFiyat = Ucret(NudAtistirmalikMiktari, AtistirmalikIsimFiyat);
            AnaSayfa.FisiGoster(FisGoster(NudAtistirmalikMiktari, AtistirmalikIsimFiyat));
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
            sonuc = goster.FisGoster(NudAtistirmalikMiktari, AtistirmalikIsimFiyat);
            return goster.FisGoster(NudAtistirmalikMiktari, AtistirmalikIsimFiyat);
        }

        public decimal Ucret(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            ToplamFiyatHesaplayici toplamFiyatHesaplayici = new ToplamFiyatHesaplayici();
            toplamFiyat = toplamFiyatHesaplayici.Ucret(NudAtistirmalikMiktari, AtistirmalikIsimFiyat);
            return toplamFiyat;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}