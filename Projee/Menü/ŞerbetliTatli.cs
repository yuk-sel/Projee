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
    public partial class SerbetliTatli : Form, INumericUpDownIslemleri, IFisGoster, IToplamFiyat
    {
        public decimal toplamFiyat;
        public string sonuc;
        private AnaSayfa AnaSayfa;
        public Dictionary<string, decimal> SerbetliTatliIsimFiyat;
        public List<NumericUpDown> NudSerbetliTatliMiktari;

        public SerbetliTatli(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            ToplamFiyatHesaplayici toplamFiyat = new ToplamFiyatHesaplayici();
            AnaSayfa = anaSayfa;
            NudSerbetliTatliMiktari = new List<NumericUpDown>()
            {
                nudBaklava,
                nudSekerpare,
                nudRevani,
                nudKemalpasa,
                nudKunefe,
                nudTulumba,
                nudIrmikHelvasi,
                nudKadayif,
            };
            NudDegerDegistirme(NudSerbetliTatliMiktari, Numericupdown_ValueChanged);

            SerbetliTatliIsimFiyat = new Dictionary<string, decimal>()
            {
                {"Baklava",75},
                {"Şekerpare",50},
                {"Revani",50},
                {"Kemalpaşa",45},
                {"Künefe",65},
                {"Tulumba",45},
                {"İrmik Helvası",40},
                {"Kadayıf",55},
            };
            NudTagAtama(NudSerbetliTatliMiktari, SerbetliTatliIsimFiyat);
        }

        private void Numericupdown_ValueChanged(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            decimal toplamFiyat = Ucret(NudSerbetliTatliMiktari, SerbetliTatliIsimFiyat);
            AnaSayfa.FisiGoster(FisGoster(NudSerbetliTatliMiktari, SerbetliTatliIsimFiyat));
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
            sonuc = goster.FisGoster(NudSerbetliTatliMiktari, SerbetliTatliIsimFiyat);
            return goster.FisGoster(NudSerbetliTatliMiktari, SerbetliTatliIsimFiyat);
        }
        public decimal Ucret(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            ToplamFiyatHesaplayici toplamFiyatHesaplayici = new ToplamFiyatHesaplayici();
            toplamFiyat = toplamFiyatHesaplayici.Ucret(NudSerbetliTatliMiktari, SerbetliTatliIsimFiyat);
            return toplamFiyatHesaplayici.Ucret(NudSerbetliTatliMiktari, SerbetliTatliIsimFiyat);
        }
    }
}