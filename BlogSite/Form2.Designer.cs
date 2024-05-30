namespace BlogSite
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKullaniciAdi2 = new TextBox();
            txtSifre2 = new TextBox();
            txtSifreTekrari = new TextBox();
            btnKayitOl = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 74);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 156);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 243);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 2;
            label3.Text = "Şifre Tekrarı:";
            // 
            // txtKullaniciAdi2
            // 
            txtKullaniciAdi2.Location = new Point(201, 71);
            txtKullaniciAdi2.Name = "txtKullaniciAdi2";
            txtKullaniciAdi2.Size = new Size(223, 31);
            txtKullaniciAdi2.TabIndex = 3;
            txtKullaniciAdi2.TextChanged += txtKullaniciAdi2_TextChanged;
            // 
            // txtSifre2
            // 
            txtSifre2.Location = new Point(201, 150);
            txtSifre2.Name = "txtSifre2";
            txtSifre2.Size = new Size(223, 31);
            txtSifre2.TabIndex = 4;
            // 
            // txtSifreTekrari
            // 
            txtSifreTekrari.Location = new Point(201, 237);
            txtSifreTekrari.Name = "txtSifreTekrari";
            txtSifreTekrari.Size = new Size(223, 31);
            txtSifreTekrari.TabIndex = 5;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(155, 329);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(112, 34);
            btnKayitOl.TabIndex = 6;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 290);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 450);
            Controls.Add(label4);
            Controls.Add(btnKayitOl);
            Controls.Add(txtSifreTekrari);
            Controls.Add(txtSifre2);
            Controls.Add(txtKullaniciAdi2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKullaniciAdi2;
        private TextBox txtSifre2;
        private TextBox txtSifreTekrari;
        private Button btnKayitOl;
        private Label label4;
    }
}