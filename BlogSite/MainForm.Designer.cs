namespace BlogSite
{
    partial class MainForm
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
            txtBaslik = new TextBox();
            pbResim = new PictureBox();
            label2 = new Label();
            rtxtContent = new RichTextBox();
            flpPanel = new FlowLayoutPanel();
            btnEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 0;
            label1.Text = "Başlık:";
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(124, 19);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(150, 31);
            txtBaslik.TabIndex = 1;
            // 
            // pbResim
            // 
            pbResim.BackColor = SystemColors.ActiveBorder;
            pbResim.Location = new Point(23, 56);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(251, 203);
            pbResim.TabIndex = 2;
            pbResim.TabStop = false;
            pbResim.Click += pbResim_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 297);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 3;
            label2.Text = "İçerik:";
            // 
            // rtxtContent
            // 
            rtxtContent.Location = new Point(88, 265);
            rtxtContent.Name = "rtxtContent";
            rtxtContent.Size = new Size(186, 144);
            rtxtContent.TabIndex = 4;
            rtxtContent.Text = "";
            // 
            // flpPanel
            // 
            flpPanel.Location = new Point(316, 25);
            flpPanel.Name = "flpPanel";
            flpPanel.Size = new Size(472, 413);
            flpPanel.TabIndex = 5;
            flpPanel.Paint += flpPanel_Paint;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(23, 431);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(251, 48);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(btnEkle);
            Controls.Add(flpPanel);
            Controls.Add(rtxtContent);
            Controls.Add(label2);
            Controls.Add(pbResim);
            Controls.Add(txtBaslik);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBaslik;
        private PictureBox pbResim;
        private Label label2;
        private RichTextBox rtxtContent;
        private FlowLayoutPanel flpPanel;
        private Button btnEkle;
    }
}