using Projee.Giriş_Sayfası;
using Projee.İşlemler;
using Projee.Giriş_Sayfası;
using Projee.İşlemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee.Menü
{
    public partial class AnaYemek : Form, INumericUpDownIslemleri, IFisGoster, IToplamFiyat
    {
        public decimal toplamFiyat;
        public string sonuc;
        private AnaSayfa AnaSayfa;
        public Dictionary<string, decimal> AnaYemekIsimFiyat;
        public List<NumericUpDown> NudAnaYemekMiktari;
        public AnaYemek(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            AnaSayfa = anaSayfa;
            NudAnaYemekMiktari = new List<NumericUpDown>()
            {
                nudKuruFasulye1,
                nudLahmacun,
                nudKöfte,
                nudİskender,
                nudKuzuTandir,
                nudDolma,
                nudLazanya,
                nudMantı,
            };
            NudDegerDegistirme(NudAnaYemekMiktari, Numericupdown_ValueChanged);

            AnaYemekIsimFiyat = new Dictionary<string, decimal>()
            {
                {"Kuru Fasulye",70},
                {"Lahmacun",50},
                {"Köfte",105},
                {"İskender",145},
                {"Kuzu Tandır",205},
                {"Dolma",70},
                {"Lazanya",125},
                {"Mantı",90},
            };
            NudTagAtama(NudAnaYemekMiktari, AnaYemekIsimFiyat);

        }
        private void Numericupdown_ValueChanged(object sender, EventArgs e)
        {
            decimal toplamFiyat = Ucret(NudAnaYemekMiktari, AnaYemekIsimFiyat);
            AnaSayfa.FisiGoster(FisGoster(NudAnaYemekMiktari, AnaYemekIsimFiyat));
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
            sonuc = goster.FisGoster(NudAnaYemekMiktari, AnaYemekIsimFiyat);
            return goster.FisGoster(NudAnaYemekMiktari, AnaYemekIsimFiyat);
        }

        public decimal Ucret(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            ToplamFiyatHesaplayici toplamFiyatHesaplayici = new ToplamFiyatHesaplayici();
            toplamFiyat = toplamFiyatHesaplayici.Ucret(NudAnaYemekMiktari, AnaYemekIsimFiyat);
            return toplamFiyat;
        }
    }
}