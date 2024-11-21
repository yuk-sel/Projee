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
using Projee.Giriş_Sayfası;

namespace Projee
{
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void btnKayitOlButonu_Click(object sender, EventArgs e)
        {
            YeniKayit yeniKayit = new YeniKayit(txtIsim.Text, txtSoyisim.Text, txtMail.Text, txtTelNoKayit.Text, txtSifreKayit.Text);
            if (txtTelNoKayit.Text.Length != 11)
            {
                MessageBox.Show("Telefon numarası geçersiz");
                this.Show();
            }
            else if (txtSifreKayit.Text.Length < 5)
            {
                MessageBox.Show("Şifre en az 5 haneli olmalı");
                this.Show();
            }
            else if (txtTelNoKayit.Text.Length != 11 && txtSifreKayit.Text.Length < 5)
            {
                MessageBox.Show("Telefon numarası geçersiz\nŞifre en az 5 haneli olmalı");
                this.Show();
            }
            else
            {
                GirisEkrani girisEkrani = new GirisEkrani(yeniKayit);
                this.Hide();
                girisEkrani.Show();
            }

        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void KayitEkrani_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void KayitEkrani_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void KayitEkrani_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void lnklblGeri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YeniKayit yeniKayit = new YeniKayit(txtIsim.Text, txtSoyisim.Text, txtMail.Text, txtTelNoKayit.Text, txtSifreKayit.Text);
            GirisEkrani girisEkrani = new GirisEkrani(yeniKayit);
            this.Hide();
            girisEkrani.Show();
        }

        private void txtIsim_Enter(object sender, EventArgs e)
        {
            if (txtIsim.Text == "Adınız")
            {
                txtIsim.Text = "";
                txtIsim.ForeColor = Color.White;
            }
        }

        private void txtIsim_Leave(object sender, EventArgs e)
        {

            if (txtIsim.Text == "")
            {
                txtIsim.Text = "Adınız";
                txtIsim.ForeColor = Color.Silver;
            }
        }

        private void txtSoyisim_Enter(object sender, EventArgs e)
        {
            if (txtSoyisim.Text == "Soyadınız")
            {
                txtSoyisim.Text = "";
                txtSoyisim.ForeColor = Color.White;
            }
        }

        private void txtSoyisim_Leave(object sender, EventArgs e)
        {
            if (txtSoyisim.Text == "")
            {
                txtSoyisim.Text = "Soyadınız";
                txtSoyisim.ForeColor = Color.Silver;
            }
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Email")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.White;
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "Email";
                txtMail.ForeColor = Color.Silver;
            }
        }

        private void txtTelNoKayit_Enter(object sender, EventArgs e)
        {
            if (txtTelNoKayit.Text == "Telefon Numaranız")
            {
                txtTelNoKayit.Text = "";
                txtTelNoKayit.ForeColor = Color.White;
            }
        }

        private void txtTelNoKayit_Leave(object sender, EventArgs e)
        {
            if (txtTelNoKayit.Text == "")
            {
                txtTelNoKayit.Text = "Telefon Numaranız";
                txtTelNoKayit.ForeColor = Color.Silver;
            }
        }

        private void txtSifreKayit_Enter(object sender, EventArgs e)
        {
            if (txtSifreKayit.Text == "Şifreniz")
            {
                txtSifreKayit.Text = "";
                txtSifreKayit.ForeColor = Color.White;
            }
        }

        private void txtSifreKayit_Leave(object sender, EventArgs e)
        {
            if (txtSifreKayit.Text == "")
            {
                txtSifreKayit.Text = "Şifreniz";
                txtSifreKayit.ForeColor = Color.Silver;
            }
        }
    }
}