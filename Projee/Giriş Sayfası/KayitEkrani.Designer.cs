namespace Projee
{
    partial class KayitEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelNoKayit = new System.Windows.Forms.TextBox();
            this.txtSifreKayit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lnklblGeri = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtIsim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIsim.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsim.ForeColor = System.Drawing.Color.Silver;
            this.txtIsim.Location = new System.Drawing.Point(298, 173);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(200, 32);
            this.txtIsim.TabIndex = 1;
            this.txtIsim.Text = "Adınız";
            this.txtIsim.Enter += new System.EventHandler(this.txtIsim_Enter);
            this.txtIsim.Leave += new System.EventHandler(this.txtIsim_Leave);
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtSoyisim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyisim.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyisim.ForeColor = System.Drawing.Color.Silver;
            this.txtSoyisim.Location = new System.Drawing.Point(298, 218);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(200, 32);
            this.txtSoyisim.TabIndex = 1;
            this.txtSoyisim.Text = "Soyadınız";
            this.txtSoyisim.Enter += new System.EventHandler(this.txtSoyisim_Enter);
            this.txtSoyisim.Leave += new System.EventHandler(this.txtSoyisim_Leave);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.Color.Silver;
            this.txtMail.Location = new System.Drawing.Point(298, 271);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 32);
            this.txtMail.TabIndex = 1;
            this.txtMail.Text = "Email";
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // txtTelNoKayit
            // 
            this.txtTelNoKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtTelNoKayit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelNoKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelNoKayit.ForeColor = System.Drawing.Color.Silver;
            this.txtTelNoKayit.Location = new System.Drawing.Point(298, 320);
            this.txtTelNoKayit.Name = "txtTelNoKayit";
            this.txtTelNoKayit.Size = new System.Drawing.Size(200, 32);
            this.txtTelNoKayit.TabIndex = 1;
            this.txtTelNoKayit.Text = "Telefon Numaranız";
            this.txtTelNoKayit.Enter += new System.EventHandler(this.txtTelNoKayit_Enter);
            this.txtTelNoKayit.Leave += new System.EventHandler(this.txtTelNoKayit_Leave);
            // 
            // txtSifreKayit
            // 
            this.txtSifreKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txtSifreKayit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifreKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifreKayit.ForeColor = System.Drawing.Color.Silver;
            this.txtSifreKayit.Location = new System.Drawing.Point(298, 376);
            this.txtSifreKayit.Name = "txtSifreKayit";
            this.txtSifreKayit.Size = new System.Drawing.Size(200, 32);
            this.txtSifreKayit.TabIndex = 1;
            this.txtSifreKayit.Text = "Şifreniz";
            this.txtSifreKayit.Enter += new System.EventHandler(this.txtSifreKayit_Enter);
            this.txtSifreKayit.Leave += new System.EventHandler(this.txtSifreKayit_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(206, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adınız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(178, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadınız";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(213, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(110, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon Numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.label5.Location = new System.Drawing.Point(221, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Şifre";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(289, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnKayitOlButonu_Click);
            // 
            // lnklblGeri
            // 
            this.lnklblGeri.ActiveLinkColor = System.Drawing.Color.Silver;
            this.lnklblGeri.AutoSize = true;
            this.lnklblGeri.BackColor = System.Drawing.Color.Transparent;
            this.lnklblGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblGeri.ForeColor = System.Drawing.Color.Black;
            this.lnklblGeri.LinkColor = System.Drawing.Color.White;
            this.lnklblGeri.Location = new System.Drawing.Point(30, 691);
            this.lnklblGeri.Name = "lnklblGeri";
            this.lnklblGeri.Size = new System.Drawing.Size(53, 26);
            this.lnklblGeri.TabIndex = 5;
            this.lnklblGeri.TabStop = true;
            this.lnklblGeri.Text = "Geri";
            this.lnklblGeri.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblGeri_LinkClicked);
            // 
            // KayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(921, 771);
            this.Controls.Add(this.lnklblGeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifreKayit);
            this.Controls.Add(this.txtTelNoKayit);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KayitEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitEkrani";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KayitEkrani_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KayitEkrani_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KayitEkrani_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelNoKayit;
        private System.Windows.Forms.TextBox txtSifreKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lnklblGeri;
    }
}