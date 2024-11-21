using Projee.İşlemler;
using Projee.Menü;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Projee.Giriş_Sayfası
{

    public partial class AnaSayfa : Form
    {
        private Label fisLabeli;
        private Corba corbaFormu;
        private AnaYemek anaYemekFormu;
        private Salata salataFormu;
        private Meze mezeformu;
        private SicakIcecek sicakIcecekFormu;
        private SogukIcecek sogukIcecekFormu;
        private SerbetliTatli serbetliTatliFormu;
        private SutluTatli sutluTatliFormu;
        private Atistirmalik atistirmalikFormu;
        public List<Form> FormSakla;
        public List<Button> masalar;
        public AnaSayfa()

        {
            InitializeComponent();
            fisLabeli = new Label();
            corbaFormu = new Corba(this);
            anaYemekFormu = new AnaYemek(this);
            salataFormu = new Salata(this);
            mezeformu = new Meze(this);
            sicakIcecekFormu = new SicakIcecek(this);
            sogukIcecekFormu = new SogukIcecek(this);
            serbetliTatliFormu = new SerbetliTatli(this);
            sutluTatliFormu = new SutluTatli(this);
            atistirmalikFormu = new Atistirmalik(this);
            FormSakla = new List<Form>();

        }
        private void GosterForm(Form formTıkla)
        {
            formTıkla.TopLevel = false;
            if (!FormSakla.Contains(formTıkla))
            {
                FormSakla.Add(formTıkla);
                pnlEkran.Controls.Add(formTıkla);
                formTıkla.Show();
            }
            foreach (var formlar in FormSakla)
            {
                if (formTıkla == formlar)
                {
                    formTıkla.BringToFront();
                }
                formTıkla.Show();
            }
        }
        public void FisiGoster(string fisEkle)
        {
            string metin = corbaFormu.sonuc + anaYemekFormu.sonuc + salataFormu.sonuc + mezeformu.sonuc + sicakIcecekFormu.sonuc + sogukIcecekFormu.sonuc + serbetliTatliFormu.sonuc + sutluTatliFormu.sonuc + atistirmalikFormu.sonuc;
            fisLabeli.AutoSize = true;
            fisLabeli.Text = metin;
            pnlFis.Controls.Add(fisLabeli);

            decimal fiyat = corbaFormu.toplamFiyat + anaYemekFormu.toplamFiyat + salataFormu.toplamFiyat + mezeformu.toplamFiyat + sicakIcecekFormu.toplamFiyat + sogukIcecekFormu.toplamFiyat + serbetliTatliFormu.toplamFiyat + sutluTatliFormu.toplamFiyat + atistirmalikFormu.toplamFiyat;
            lblFiyat.Text = fiyat.ToString();
            if (lblFiyat.Text != "0")
            {
                btnSiparis.Enabled = true;
            }
            else
            {
                btnSiparis.Enabled = false;
            }
        }
        private void btnCorba_Click(object sender, EventArgs e)
        {
            GosterForm(corbaFormu);
        }
        private void btnAnaYemek_Click(object sender, EventArgs e)
        {
            GosterForm(anaYemekFormu);
        }
        private void btnSalata_Click(object sender, EventArgs e)
        {
            GosterForm(salataFormu);
        }

        private void btnMeze_Click(object sender, EventArgs e)
        {
            GosterForm(mezeformu);
        }

        private void btnSicakIcecek_Click(object sender, EventArgs e)
        {
            GosterForm(sicakIcecekFormu);
        }

        private void btnSogukIcecek_Click(object sender, EventArgs e)
        {
            GosterForm(sogukIcecekFormu);
        }

        private void btnSerbetliTatli_Click(object sender, EventArgs e)
        {
            GosterForm(serbetliTatliFormu);
        }

        private void btnSutluTatli_Click(object sender, EventArgs e)
        {
            GosterForm(sutluTatliFormu);
        }


        //private void menu_Click(object sender, EventArgs e)
        //{
        //    menuTransition.Start();
        //}

        private void CARPI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();
            this.Hide();
            odeme.Show();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void btnSiparis_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void btnSiparis_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void btnSiparis_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void btnatis_Click(object sender, EventArgs e)
        {
            GosterForm(atistirmalikFormu);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}