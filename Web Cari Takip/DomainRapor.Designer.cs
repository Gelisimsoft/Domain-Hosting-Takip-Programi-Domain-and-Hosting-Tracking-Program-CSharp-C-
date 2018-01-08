namespace Domain_Hosting
{
    partial class DomainRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DomainRapor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unvanbtn = new System.Windows.Forms.Button();
            this.unvanlist = new System.Windows.Forms.ListBox();
            this.Unvanbox = new System.Windows.Forms.TextBox();
            this.Guncllbtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tutardomainbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AlinanFirma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DomainBitis = new System.Windows.Forms.DateTimePicker();
            this.DomainBaslangic = new System.Windows.Forms.DateTimePicker();
            this.AlanAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unvanbtn);
            this.groupBox1.Controls.Add(this.unvanlist);
            this.groupBox1.Controls.Add(this.Unvanbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ünvana Göre Ara";
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
            // unvanlist
            // 
            this.unvanlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.unvanlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unvanlist.ForeColor = System.Drawing.Color.White;
            this.unvanlist.FormattingEnabled = true;
            this.unvanlist.Location = new System.Drawing.Point(6, 71);
            this.unvanlist.Name = "unvanlist";
            this.unvanlist.Size = new System.Drawing.Size(161, 225);
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
            // Guncllbtn
            // 
            this.Guncllbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Guncllbtn.Location = new System.Drawing.Point(9, 149);
            this.Guncllbtn.Name = "Guncllbtn";
            this.Guncllbtn.Size = new System.Drawing.Size(98, 29);
            this.Guncllbtn.TabIndex = 1;
            this.Guncllbtn.Text = "GÜNCELLE";
            this.Guncllbtn.UseVisualStyleBackColor = true;
            this.Guncllbtn.Click += new System.EventHandler(this.Guncllbtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.tutardomainbox);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.AlinanFirma);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.DomainBitis);
            this.groupBox4.Controls.Add(this.DomainBaslangic);
            this.groupBox4.Controls.Add(this.AlanAdi);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Guncllbtn);
            this.groupBox4.Location = new System.Drawing.Point(191, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 184);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kayıtlı Domain Bilgileri";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(121, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 29);
            this.button1.TabIndex = 33;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tutardomainbox
            // 
            this.tutardomainbox.Location = new System.Drawing.Point(76, 123);
            this.tutardomainbox.Name = "tutardomainbox";
            this.tutardomainbox.Size = new System.Drawing.Size(143, 20);
            this.tutardomainbox.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Tutar";
            // 
            // AlinanFirma
            // 
            this.AlinanFirma.Location = new System.Drawing.Point(76, 19);
            this.AlinanFirma.Name = "AlinanFirma";
            this.AlinanFirma.Size = new System.Drawing.Size(143, 20);
            this.AlinanFirma.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Alınan Firma";
            // 
            // DomainBitis
            // 
            this.DomainBitis.Location = new System.Drawing.Point(76, 97);
            this.DomainBitis.Name = "DomainBitis";
            this.DomainBitis.Size = new System.Drawing.Size(143, 20);
            this.DomainBitis.TabIndex = 19;
            // 
            // DomainBaslangic
            // 
            this.DomainBaslangic.Location = new System.Drawing.Point(76, 71);
            this.DomainBaslangic.Name = "DomainBaslangic";
            this.DomainBaslangic.Size = new System.Drawing.Size(143, 20);
            this.DomainBaslangic.TabIndex = 18;
            // 
            // AlanAdi
            // 
            this.AlanAdi.Location = new System.Drawing.Point(76, 45);
            this.AlanAdi.Name = "AlanAdi";
            this.AlanAdi.Size = new System.Drawing.Size(143, 20);
            this.AlanAdi.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Başlangıç";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bitiş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alan Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(191, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 116);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Firma Adına Kayıtlı Domainler";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // DomainRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DomainRapor";
            this.Text = "Domain Raporlama ve Güncelleme";
            this.Load += new System.EventHandler(this.DomainRapor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DomainRapor_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox unvanlist;
        private System.Windows.Forms.TextBox Unvanbox;
        private System.Windows.Forms.Button unvanbtn;
        private System.Windows.Forms.Button Guncllbtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox AlinanFirma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DomainBitis;
        private System.Windows.Forms.DateTimePicker DomainBaslangic;
        private System.Windows.Forms.TextBox AlanAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tutardomainbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}