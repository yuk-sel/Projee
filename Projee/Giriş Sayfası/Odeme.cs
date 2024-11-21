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

namespace Projee.Giriş_Sayfası
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
            txtIsim.TextChanged += TextBox_TextChanged;
            txtKart.TextChanged += TextBox_TextChanged;
            txtCvv.TextChanged += TextBox_TextChanged;
            cmbAy.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cmbYil.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            butongoster();
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            butongoster();
        }
        public void butongoster()
        {
            if (txtIsim.Text == "" || txtKart.Text == "" || txtCvv.Text == "" || cmbAy.SelectedItem == null || cmbYil.SelectedItem == null)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Odeme_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Odeme_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Odeme_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.Show();
        }
    }
}