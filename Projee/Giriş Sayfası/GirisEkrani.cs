using Projee.Giriş_Sayfası;
using Projee.İşlemler;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projee;
using System.Collections.Generic;

namespace Projee
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani(YeniKayit yeniKayit)
        {
            InitializeComponent();
            KayitBilgileri = yeniKayit;
        }

        YeniKayit KayitBilgileri;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            YeniKayit girisBilgileri = new YeniKayit(txtTelNo.Text, txtSifre.Text);
            if (txtSifre.Text != KayitBilgileri.Sifre || txtTelNo.Text != KayitBilgileri.TelNo)
            {
                MessageBox.Show("Telefon numarası ya da şifre hatalı!");
            }
            else
            {
                Masalar masalar = new Masalar();
                this.Hide();
                masalar.Show();
                //AnaSayfa anaSayfa = new AnaSayfa();
                //this.Hide();
                //anaSayfa.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void GirisEkrani_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void GirisEkrani_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void GirisEkrani_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void txtTelNo_Enter(object sender, EventArgs e)
        {
            if (txtTelNo.Text == "Telefon Numarası")
            {
                txtTelNo.Text = "";
                txtTelNo.ForeColor = Color.White;
            }
        }

        private void txtTelNo_Leave(object sender, EventArgs e)
        {
            if (txtTelNo.Text == "")
            {
                txtTelNo.Text = "Telefon Numarası";
                txtTelNo.ForeColor = Color.Silver;
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.Text = "";
                txtSifre.ForeColor = Color.White;
                txtSifre.PasswordChar = '*';
            }
        }

        char? none = null;

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Şifre";
                txtSifre.ForeColor = Color.Silver;
                txtSifre.PasswordChar = Convert.ToChar(none);
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitEkrani kayitEkrani = new KayitEkrani();
            this.Hide();
            kayitEkrani.Show();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}