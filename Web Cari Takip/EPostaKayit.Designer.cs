namespace Domain_Hosting
{
    partial class EPostaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EPostaKayit));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PostaEkle = new System.Windows.Forms.Button();
            this.EpostaSifre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EpostaAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FirmaCombo = new System.Windows.Forms.ComboBox();
            this.MusteriEkleBtn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PostaEkle);
            this.groupBox3.Controls.Add(this.EpostaSifre);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.EpostaAd);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "E - Posta Ekle";
            // 
            // PostaEkle
            // 
            this.PostaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PostaEkle.Location = new System.Drawing.Point(66, 78);
            this.PostaEkle.Name = "PostaEkle";
            this.PostaEkle.Size = new System.Drawing.Size(153, 26);
            this.PostaEkle.TabIndex = 15;
            this.PostaEkle.Text = "E - Posta Ekle";
            this.PostaEkle.UseVisualStyleBackColor = true;
            this.PostaEkle.Click += new System.EventHandler(this.PostaEkle_Click);
            // 
            // EpostaSifre
            // 
            this.EpostaSifre.Location = new System.Drawing.Point(66, 39);
            this.EpostaSifre.Name = "EpostaSifre";
            this.EpostaSifre.Size = new System.Drawing.Size(153, 20);
            this.EpostaSifre.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Şifre";
            // 
            // EpostaAd
            // 
            this.EpostaAd.Location = new System.Drawing.Point(66, 17);
            this.EpostaAd.Name = "EpostaAd";
            this.EpostaAd.Size = new System.Drawing.Size(153, 20);
            this.EpostaAd.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Adres";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FirmaCombo);
            this.groupBox4.Controls.Add(this.MusteriEkleBtn);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 44);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Müşteri Carisi";
            // 
            // FirmaCombo
            // 
            this.FirmaCombo.FormattingEnabled = true;
            this.FirmaCombo.Location = new System.Drawing.Point(6, 16);
            this.FirmaCombo.Name = "FirmaCombo";
            this.FirmaCombo.Size = new System.Drawing.Size(221, 21);
            this.FirmaCombo.TabIndex = 1;
            // 
            // MusteriEkleBtn
            // 
            this.MusteriEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriEkleBtn.Location = new System.Drawing.Point(232, 16);
            this.MusteriEkleBtn.Name = "MusteriEkleBtn";
            this.MusteriEkleBtn.Size = new System.Drawing.Size(52, 25);
            this.MusteriEkleBtn.TabIndex = 7;
            this.MusteriEkleBtn.Text = "Ekle";
            this.MusteriEkleBtn.UseVisualStyleBackColor = true;
            this.MusteriEkleBtn.Click += new System.EventHandler(this.MusteriEkleBtn_Click);
            // 
            // EPostaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 182);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EPostaKayit";
            this.Text = "Web Hosting Tanımlama";
            this.Load += new System.EventHandler(this.WebHosting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WebHosting_KeyDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PostaEkle;
        private System.Windows.Forms.TextBox EpostaSifre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EpostaAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox FirmaCombo;
        private System.Windows.Forms.Button MusteriEkleBtn;
    }
}