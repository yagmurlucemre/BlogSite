namespace BlogSite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            lnkLblKayitOl = new LinkLabel();
            label3 = new Label();
            lblErrorMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 140);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(44, 82);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(277, 31);
            txtKullaniciAdi.TabIndex = 2;
            txtKullaniciAdi.TextChanged += txtKullaniciAdi_TextChanged;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(44, 186);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(277, 31);
            txtSifre.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(128, 272);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(112, 34);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // lnkLblKayitOl
            // 
            lnkLblKayitOl.AutoSize = true;
            lnkLblKayitOl.Location = new Point(70, 327);
            lnkLblKayitOl.Name = "lnkLblKayitOl";
            lnkLblKayitOl.Size = new Size(229, 25);
            lnkLblKayitOl.TabIndex = 5;
            lnkLblKayitOl.TabStop = true;
            lnkLblKayitOl.Text = "Kayıtlı Değilseniz Kayıt Olun";
            lnkLblKayitOl.LinkClicked += lnkLblKayitOl_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 234);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 6;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Location = new Point(156, 234);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 25);
            lblErrorMessage.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 450);
            Controls.Add(lblErrorMessage);
            Controls.Add(label3);
            Controls.Add(lnkLblKayitOl);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGirisYap;
        private LinkLabel lnkLblKayitOl;
        private Label label3;
        private Label lblErrorMessage;
    }
}
