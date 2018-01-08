namespace Domain_Hosting
{
    partial class TahsilatRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TahsilatRapor));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unvanbtn = new System.Windows.Forms.Button();
            this.unvanlist = new System.Windows.Forms.ListBox();
            this.Unvanbox = new System.Windows.Forms.TextBox();
            this.TahsilatGroupBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GuncellemeGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Guncllbtn = new System.Windows.Forms.Button();
            this.aciklamabox = new System.Windows.Forms.TextBox();
            this.tutarbox = new System.Windows.Forms.TextBox();
            this.UrunCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HizmetCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.TahsilatGroupBox.SuspendLayout();
            this.GuncellemeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(120, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 43);
            this.button1.TabIndex = 33;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unvanbtn);
            this.groupBox1.Controls.Add(this.unvanlist);
            this.groupBox1.Controls.Add(this.Unvanbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 306);
            this.groupBox1.TabIndex = 3;
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
            // TahsilatGroupBox
            // 
            this.TahsilatGroupBox.Controls.Add(this.listBox1);
            this.TahsilatGroupBox.Enabled = false;
            this.TahsilatGroupBox.Location = new System.Drawing.Point(191, 12);
            this.TahsilatGroupBox.Name = "TahsilatGroupBox";
            this.TahsilatGroupBox.Size = new System.Drawing.Size(247, 306);
            this.TahsilatGroupBox.TabIndex = 5;
            this.TahsilatGroupBox.TabStop = false;
            this.TahsilatGroupBox.Text = "Firma Adına Kayıtlı Tahsilatlar";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 277);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // GuncellemeGroupBox
            // 
            this.GuncellemeGroupBox.Controls.Add(this.dateTimePicker1);
            this.GuncellemeGroupBox.Controls.Add(this.button1);
            this.GuncellemeGroupBox.Controls.Add(this.label7);
            this.GuncellemeGroupBox.Controls.Add(this.Guncllbtn);
            this.GuncellemeGroupBox.Controls.Add(this.aciklamabox);
            this.GuncellemeGroupBox.Controls.Add(this.tutarbox);
            this.GuncellemeGroupBox.Controls.Add(this.UrunCombo);
            this.GuncellemeGroupBox.Controls.Add(this.label2);
            this.GuncellemeGroupBox.Controls.Add(this.HizmetCombo);
            this.GuncellemeGroupBox.Controls.Add(this.label4);
            this.GuncellemeGroupBox.Controls.Add(this.label5);
            this.GuncellemeGroupBox.Controls.Add(this.label3);
            this.GuncellemeGroupBox.Enabled = false;
            this.GuncellemeGroupBox.Location = new System.Drawing.Point(444, 12);
            this.GuncellemeGroupBox.Name = "GuncellemeGroupBox";
            this.GuncellemeGroupBox.Size = new System.Drawing.Size(224, 306);
            this.GuncellemeGroupBox.TabIndex = 4;
            this.GuncellemeGroupBox.TabStop = false;
            this.GuncellemeGroupBox.Text = "Kayıtlı Tahsilat Bilgileri";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tarih";
            // 
            // Guncllbtn
            // 
            this.Guncllbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Guncllbtn.Location = new System.Drawing.Point(16, 249);
            this.Guncllbtn.Name = "Guncllbtn";
            this.Guncllbtn.Size = new System.Drawing.Size(98, 43);
            this.Guncllbtn.TabIndex = 1;
            this.Guncllbtn.Text = "GÜNCELLE";
            this.Guncllbtn.UseVisualStyleBackColor = true;
            this.Guncllbtn.Click += new System.EventHandler(this.Guncllbtn_Click);
            // 
            // aciklamabox
            // 
            this.aciklamabox.Location = new System.Drawing.Point(64, 137);
            this.aciklamabox.Multiline = true;
            this.aciklamabox.Name = "aciklamabox";
            this.aciklamabox.Size = new System.Drawing.Size(154, 97);
            this.aciklamabox.TabIndex = 15;
            // 
            // tutarbox
            // 
            this.tutarbox.Location = new System.Drawing.Point(64, 111);
            this.tutarbox.Name = "tutarbox";
            this.tutarbox.Size = new System.Drawing.Size(154, 20);
            this.tutarbox.TabIndex = 16;
            // 
            // UrunCombo
            // 
            this.UrunCombo.FormattingEnabled = true;
            this.UrunCombo.Location = new System.Drawing.Point(64, 54);
            this.UrunCombo.Name = "UrunCombo";
            this.UrunCombo.Size = new System.Drawing.Size(154, 21);
            this.UrunCombo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hizmet";
            // 
            // HizmetCombo
            // 
            this.HizmetCombo.FormattingEnabled = true;
            this.HizmetCombo.Items.AddRange(new object[] {
            "Hosting",
            "Domain"});
            this.HizmetCombo.Location = new System.Drawing.Point(64, 27);
            this.HizmetCombo.Name = "HizmetCombo";
            this.HizmetCombo.Size = new System.Drawing.Size(154, 21);
            this.HizmetCombo.TabIndex = 14;
            this.HizmetCombo.SelectedIndexChanged += new System.EventHandler(this.HizmetCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ürünler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tutar";
            // 
            // TahsilatRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TahsilatGroupBox);
            this.Controls.Add(this.GuncellemeGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TahsilatRapor";
            this.Text = "Tahsilat Rapor ve Güncelleme";
            this.Load += new System.EventHandler(this.TahsilatRapor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TahsilatRapor_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TahsilatGroupBox.ResumeLayout(false);
            this.GuncellemeGroupBox.ResumeLayout(false);
            this.GuncellemeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button unvanbtn;
        private System.Windows.Forms.ListBox unvanlist;
        private System.Windows.Forms.TextBox Unvanbox;
        private System.Windows.Forms.GroupBox TahsilatGroupBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox GuncellemeGroupBox;
        private System.Windows.Forms.Button Guncllbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox aciklamabox;
        private System.Windows.Forms.TextBox tutarbox;
        private System.Windows.Forms.ComboBox UrunCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox HizmetCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}