namespace Domain_Hosting
{
    partial class HostingRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostingRapor));
            this.unvanbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unvanlist = new System.Windows.Forms.ListBox();
            this.Unvanbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tutarhost = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.HostingEkle = new System.Windows.Forms.Button();
            this.HostingBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.HostingBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PSifre = new System.Windows.Forms.TextBox();
            this.FtpSifre = new System.Windows.Forms.TextBox();
            this.FtpAdres = new System.Windows.Forms.TextBox();
            this.FtpKullanici = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.FtpSifrelbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pkullanici = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // unvanbtn
            // 
            this.unvanbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unvanbtn.Location = new System.Drawing.Point(6, 45);
            this.unvanbtn.Name = "unvanbtn";
            this.unvanbtn.Size = new System.Drawing.Size(161, 23);
            this.unvanbtn.TabIndex = 2;
            this.unvanbtn.Text = "ARA";
            this.unvanbtn.UseVisualStyleBackColor = true;
            this.unvanbtn.Click += new System.EventHandler(this.unvanbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unvanbtn);
            this.groupBox1.Controls.Add(this.unvanlist);
            this.groupBox1.Controls.Add(this.Unvanbox);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ünvana Göre Ara";
            // 
            // unvanlist
            // 
            this.unvanlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.unvanlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unvanlist.FormattingEnabled = true;
            this.unvanlist.Location = new System.Drawing.Point(6, 71);
            this.unvanlist.Name = "unvanlist";
            this.unvanlist.Size = new System.Drawing.Size(161, 186);
            this.unvanlist.TabIndex = 1;
            this.unvanlist.Click += new System.EventHandler(this.unvanlist_Click);
            // 
            // Unvanbox
            // 
            this.Unvanbox.Location = new System.Drawing.Point(6, 19);
            this.Unvanbox.Name = "Unvanbox";
            this.Unvanbox.Size = new System.Drawing.Size(161, 20);
            this.Unvanbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(187, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 262);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Firma Adına Kayıtlı Hostingler";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 225);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.tutarhost);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.HostingEkle);
            this.groupBox3.Controls.Add(this.HostingBitis);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.HostingBaslangic);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.PSifre);
            this.groupBox3.Controls.Add(this.FtpSifre);
            this.groupBox3.Controls.Add(this.FtpAdres);
            this.groupBox3.Controls.Add(this.FtpKullanici);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.FtpSifrelbl);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Pkullanici);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(405, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 262);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hosting Tanımlama";
            // 
            // tutarhost
            // 
            this.tutarhost.Location = new System.Drawing.Point(93, 201);
            this.tutarhost.Name = "tutarhost";
            this.tutarhost.Size = new System.Drawing.Size(200, 20);
            this.tutarhost.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Tutar";
            // 
            // HostingEkle
            // 
            this.HostingEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HostingEkle.Location = new System.Drawing.Point(93, 226);
            this.HostingEkle.Name = "HostingEkle";
            this.HostingEkle.Size = new System.Drawing.Size(95, 30);
            this.HostingEkle.TabIndex = 7;
            this.HostingEkle.Text = "GÜNCELLE";
            this.HostingEkle.UseVisualStyleBackColor = true;
            this.HostingEkle.Click += new System.EventHandler(this.HostingEkle_Click);
            // 
            // HostingBitis
            // 
            this.HostingBitis.Location = new System.Drawing.Point(93, 175);
            this.HostingBitis.Name = "HostingBitis";
            this.HostingBitis.Size = new System.Drawing.Size(200, 20);
            this.HostingBitis.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Bitiş";
            // 
            // HostingBaslangic
            // 
            this.HostingBaslangic.CustomFormat = "dd mm YYYY dd";
            this.HostingBaslangic.Location = new System.Drawing.Point(93, 149);
            this.HostingBaslangic.Name = "HostingBaslangic";
            this.HostingBaslangic.Size = new System.Drawing.Size(200, 20);
            this.HostingBaslangic.TabIndex = 5;
            this.HostingBaslangic.Value = new System.DateTime(2011, 4, 8, 11, 40, 3, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Başlangıç";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Panel Şifre";
            // 
            // PSifre
            // 
            this.PSifre.Location = new System.Drawing.Point(93, 45);
            this.PSifre.Name = "PSifre";
            this.PSifre.Size = new System.Drawing.Size(200, 20);
            this.PSifre.TabIndex = 1;
            // 
            // FtpSifre
            // 
            this.FtpSifre.Location = new System.Drawing.Point(93, 123);
            this.FtpSifre.Name = "FtpSifre";
            this.FtpSifre.Size = new System.Drawing.Size(200, 20);
            this.FtpSifre.TabIndex = 4;
            // 
            // FtpAdres
            // 
            this.FtpAdres.Location = new System.Drawing.Point(93, 71);
            this.FtpAdres.Name = "FtpAdres";
            this.FtpAdres.Size = new System.Drawing.Size(200, 20);
            this.FtpAdres.TabIndex = 3;
            // 
            // FtpKullanici
            // 
            this.FtpKullanici.Location = new System.Drawing.Point(93, 97);
            this.FtpKullanici.Name = "FtpKullanici";
            this.FtpKullanici.Size = new System.Drawing.Size(200, 20);
            this.FtpKullanici.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Ftp Adres";
            // 
            // FtpSifrelbl
            // 
            this.FtpSifrelbl.AutoSize = true;
            this.FtpSifrelbl.Location = new System.Drawing.Point(5, 124);
            this.FtpSifrelbl.Name = "FtpSifrelbl";
            this.FtpSifrelbl.Size = new System.Drawing.Size(46, 13);
            this.FtpSifrelbl.TabIndex = 11;
            this.FtpSifrelbl.Text = "Ftp Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ftp Kullanıcı";
            // 
            // Pkullanici
            // 
            this.Pkullanici.Location = new System.Drawing.Point(93, 19);
            this.Pkullanici.Name = "Pkullanici";
            this.Pkullanici.Size = new System.Drawing.Size(200, 20);
            this.Pkullanici.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Panel  Kullanıcı ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(198, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 32;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HostingRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 276);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HostingRapor";
            this.Text = "Hosting Rapor ve Güncelleme";
            this.Load += new System.EventHandler(this.HostingRapor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HostingRapor_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button unvanbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox unvanlist;
        private System.Windows.Forms.TextBox Unvanbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tutarhost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button HostingEkle;
        private System.Windows.Forms.DateTimePicker HostingBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker HostingBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PSifre;
        private System.Windows.Forms.TextBox FtpSifre;
        private System.Windows.Forms.TextBox FtpAdres;
        private System.Windows.Forms.TextBox FtpKullanici;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label FtpSifrelbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Pkullanici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}