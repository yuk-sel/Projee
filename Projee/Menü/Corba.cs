using Projee.Giriş_Sayfası;
using Projee.İşlemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee.Menü
{
    public partial class Corba : Form, INumericUpDownIslemleri, IFisGoster, IToplamFiyat
    {
        public decimal toplamFiyat;
        private AnaSayfa AnaSayfa;
        public string sonuc;
        public List<NumericUpDown> NudCorbaMiktari;
        public Dictionary<string, decimal> CorbaIsimFiyat;

        public Corba(AnaSayfa anaSayfa)
        {

            InitializeComponent();

            AnaSayfa = anaSayfa;
            NudCorbaMiktari = new List<NumericUpDown>()
            {
                nudMercimek,
                nudYayla,
                nudTavuk,
                nudTarhana,
                nudDomates,
                nudDugun,
                nudEzogelin,
                nudSebzze,
            };

            NudDegerDegistirme(NudCorbaMiktari, Numericupdown_ValueChanged);

            CorbaIsimFiyat = new Dictionary<string, decimal>()
            {
                {"Mercimek Çorbası",40},
                {"Yayla Çorbası",40},
                {"Tavuk Çorbası",50},
                {"Tarhana Çorbası",45},
                {"Domates Çorbası",35},
                {"Düğün Çorbası",35},
                {"Ezogelin Çorbası",40},
                {"Sebze Çorbası",55},

            };


            NudTagAtama(NudCorbaMiktari, CorbaIsimFiyat);


        }
        public void Numericupdown_ValueChanged(object sender, EventArgs e)
        {
            //  AnaSayfa anaSayfa = new AnaSayfa();
            decimal toplamFiyat = Ucret(NudCorbaMiktari, CorbaIsimFiyat);
            AnaSayfa.FisiGoster(FisGoster(NudCorbaMiktari, CorbaIsimFiyat));
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

            sonuc = goster.FisGoster(NudCorbaMiktari, CorbaIsimFiyat);
            return goster.FisGoster(NudCorbaMiktari, CorbaIsimFiyat);
        }

        public decimal Ucret(List<NumericUpDown> miktar, Dictionary<string, decimal> fiyat)
        {
            ToplamFiyatHesaplayici toplamFiyatHesaplayici = new ToplamFiyatHesaplayici();
            toplamFiyat = toplamFiyatHesaplayici.Ucret(NudCorbaMiktari, CorbaIsimFiyat);
            return toplamFiyat;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}