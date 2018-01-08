namespace Domain_Hosting
{
    partial class DomainKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DomainKayit));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tutardomainbox = new System.Windows.Forms.TextBox();
            this.AlinanFirma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DomainBitis = new System.Windows.Forms.DateTimePicker();
            this.DomainBaslangic = new System.Windows.Forms.DateTimePicker();
            this.DomainEkle = new System.Windows.Forms.Button();
            this.AlanAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FirmaCombo = new System.Windows.Forms.ComboBox();
            this.MusteriEkleBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tutardomainbox);
            this.groupBox2.Controls.Add(this.AlinanFirma);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DomainBitis);
            this.groupBox2.Controls.Add(this.DomainBaslangic);
            this.groupBox2.Controls.Add(this.DomainEkle);
            this.groupBox2.Controls.Add(this.AlanAdi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Domain Tanımlama";
            // 
            // tutardomainbox
            // 
            this.tutardomainbox.Location = new System.Drawing.Point(76, 153);
            this.tutardomainbox.Name = "tutardomainbox";
            this.tutardomainbox.Size = new System.Drawing.Size(208, 20);
            this.tutardomainbox.TabIndex = 20;
            // 
            // AlinanFirma
            // 
            this.AlinanFirma.Location = new System.Drawing.Point(76, 21);
            this.AlinanFirma.Name = "AlinanFirma";
            this.AlinanFirma.Size = new System.Drawing.Size(208, 20);
            this.AlinanFirma.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Alınan Firma";
            // 
            // DomainBitis
            // 
            this.DomainBitis.Location = new System.Drawing.Point(76, 91);
            this.DomainBitis.Name = "DomainBitis";
            this.DomainBitis.Size = new System.Drawing.Size(208, 20);
            this.DomainBitis.TabIndex = 11;
            // 
            // DomainBaslangic
            // 
            this.DomainBaslangic.Location = new System.Drawing.Point(76, 68);
            this.DomainBaslangic.Name = "DomainBaslangic";
            this.DomainBaslangic.Size = new System.Drawing.Size(208, 20);
            this.DomainBaslangic.TabIndex = 10;
            // 
            // DomainEkle
            // 
            this.DomainEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DomainEkle.Location = new System.Drawing.Point(76, 188);
            this.DomainEkle.Name = "DomainEkle";
            this.DomainEkle.Size = new System.Drawing.Size(208, 23);
            this.DomainEkle.TabIndex = 12;
            this.DomainEkle.Text = "Domain Ekle";
            this.DomainEkle.UseVisualStyleBackColor = true;
            this.DomainEkle.Click += new System.EventHandler(this.DomainEkle_Click);
            // 
            // AlanAdi
            // 
            this.AlanAdi.Location = new System.Drawing.Point(76, 45);
            this.AlanAdi.Name = "AlanAdi";
            this.AlanAdi.Size = new System.Drawing.Size(208, 20);
            this.AlanAdi.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Başlangıç";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Bitiş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alan Adı";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FirmaCombo);
            this.groupBox4.Controls.Add(this.MusteriEkleBtn);
            this.groupBox4.Location = new System.Drawing.Point(12, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 44);
            this.groupBox4.TabIndex = 4;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Müşterinin Ödeyeceği Tutar";
            // 
            // DomainKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 287);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DomainKayit";
            this.Text = "Domain Tanımlama";
            this.Load += new System.EventHandler(this.WebHosting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WebHosting_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DomainBitis;
        private System.Windows.Forms.DateTimePicker DomainBaslangic;
        private System.Windows.Forms.Button DomainEkle;
        private System.Windows.Forms.TextBox AlanAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AlinanFirma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tutardomainbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox FirmaCombo;
        private System.Windows.Forms.Button MusteriEkleBtn;
        private System.Windows.Forms.Label label12;
    }
}