using Projee.Giriş_Sayfası;
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
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
            btnMasaSec.Enabled = false;
        }

        private void btnMasaSec_Click(object sender, EventArgs e)
        {

            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.Show();
        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            if (btnMasa1.BackColor == Color.Red)
            {
                btnMasaSec.Enabled = false;
                MessageBox.Show("Bu masa dolu");
            }
            else
            {
                btnMasaSec.Enabled = true;
            }
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            if (btnMasa2.BackColor == Color.Red)
            {
                btnMasaSec.Enabled = false;
                MessageBox.Show("Bu masa dolu");
            }
            else
            {
                btnMasaSec.Enabled = true;
            }
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            if (btnMasa3.BackColor == Color.Red)
            {
                btnMasaSec.Enabled = false;
                MessageBox.Show("Bu masa dolu");
            }
            else
            {
                btnMasaSec.Enabled = true;
            }
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            if (btnMasa4.BackColor == Color.Red)
            {
                btnMasaSec.Enabled = false;
                MessageBox.Show("Bu masa dolu");
            }
            else
            {
                btnMasaSec.Enabled = true;
            }
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            if (btnMasa5.BackColor == Color.Red)
            {
                btnMasaSec.Enabled = false;
                MessageBox.Show("Bu masa dolu");
            }
            else
            {
                btnMasaSec.Enabled = true;
            }
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            if (btnMasa6.BackColor == Color.Red)
            {
                btnMasaSec.Enabled = false;
                MessageBox.Show("Bu masa dolu");
            }
            else
            {
                btnMasaSec.Enabled = true;
            }
        }




        //private void button3_Click_1(object sender, EventArgs e)
        //{
        //    if (btnMasa2.BackColor == Color.Red)
        //    {
        //        btnMasaSec.Enabled = false;
        //        MessageBox.Show("Bu masa dolu");
        //    }
        //    else
        //    {
        //        btnMasaSec.Enabled = true;
        //    }
        //}


        //private void btnMasaSec_Click(object sender, EventArgs e)
        //{
        //    btnMasaSec.Enabled = false;
        //    btnMenu.Enabled = true;
        //}
    }
}