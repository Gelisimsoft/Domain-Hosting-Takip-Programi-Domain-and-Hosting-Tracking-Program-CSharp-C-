namespace Domain_Hosting
{
    partial class Tahsilat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tahsilat));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.KayitekleBtn = new System.Windows.Forms.Button();
            this.aciklamabox = new System.Windows.Forms.TextBox();
            this.tutarbox = new System.Windows.Forms.TextBox();
            this.UrunCombo = new System.Windows.Forms.ComboBox();
            this.HizmetCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MusteriCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TahBilgileriniGetirBtn = new System.Windows.Forms.Button();
            this.RaporMusteriGetirCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.KayitekleBtn);
            this.groupBox1.Controls.Add(this.aciklamabox);
            this.groupBox1.Controls.Add(this.tutarbox);
            this.groupBox1.Controls.Add(this.UrunCombo);
            this.groupBox1.Controls.Add(this.HizmetCombo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MusteriCombo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tahsilat Açıklama Bilgileri";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tarih";
            // 
            // KayitekleBtn
            // 
            this.KayitekleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitekleBtn.Location = new System.Drawing.Point(553, 15);
            this.KayitekleBtn.Name = "KayitekleBtn";
            this.KayitekleBtn.Size = new System.Drawing.Size(75, 71);
            this.KayitekleBtn.TabIndex = 4;
            this.KayitekleBtn.Text = "Ekle";
            this.KayitekleBtn.UseVisualStyleBackColor = true;
            this.KayitekleBtn.Click += new System.EventHandler(this.KayitekleBtn_Click);
            // 
            // aciklamabox
            // 
            this.aciklamabox.Location = new System.Drawing.Point(404, 44);
            this.aciklamabox.Multiline = true;
            this.aciklamabox.Name = "aciklamabox";
            this.aciklamabox.Size = new System.Drawing.Size(143, 42);
            this.aciklamabox.TabIndex = 3;
            // 
            // tutarbox
            // 
            this.tutarbox.Location = new System.Drawing.Point(54, 44);
            this.tutarbox.Name = "tutarbox";
            this.tutarbox.Size = new System.Drawing.Size(121, 20);
            this.tutarbox.TabIndex = 3;
            // 
            // UrunCombo
            // 
            this.UrunCombo.Enabled = false;
            this.UrunCombo.FormattingEnabled = true;
            this.UrunCombo.Location = new System.Drawing.Point(404, 17);
            this.UrunCombo.Name = "UrunCombo";
            this.UrunCombo.Size = new System.Drawing.Size(143, 21);
            this.UrunCombo.TabIndex = 2;
            // 
            // HizmetCombo
            // 
            this.HizmetCombo.Enabled = false;
            this.HizmetCombo.FormattingEnabled = true;
            this.HizmetCombo.Items.AddRange(new object[] {
            "Hosting",
            "Domain"});
            this.HizmetCombo.Location = new System.Drawing.Point(222, 17);
            this.HizmetCombo.Name = "HizmetCombo";
            this.HizmetCombo.Size = new System.Drawing.Size(123, 21);
            this.HizmetCombo.TabIndex = 2;
            this.HizmetCombo.Text = "Lütfen Seçiniz";
            this.HizmetCombo.SelectedIndexChanged += new System.EventHandler(this.HizmetCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Açıklama";
            // 
            // MusteriCombo
            // 
            this.MusteriCombo.FormattingEnabled = true;
            this.MusteriCombo.Location = new System.Drawing.Point(54, 17);
            this.MusteriCombo.Name = "MusteriCombo";
            this.MusteriCombo.Size = new System.Drawing.Size(121, 21);
            this.MusteriCombo.TabIndex = 2;
            this.MusteriCombo.SelectedIndexChanged += new System.EventHandler(this.MusteriCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tutar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ürünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hizmet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(11, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistemde Kayıtlı Tahsilatlar";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(10, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(619, 279);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hizmet";
            this.columnHeader2.Width = 61;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tutar";
            this.columnHeader4.Width = 59;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tarih";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Açıklama";
            this.columnHeader6.Width = 201;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TahBilgileriniGetirBtn);
            this.groupBox3.Controls.Add(this.RaporMusteriGetirCombo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(11, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Raporlama Seçenekleri";
            // 
            // TahBilgileriniGetirBtn
            // 
            this.TahBilgileriniGetirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TahBilgileriniGetirBtn.Location = new System.Drawing.Point(361, 17);
            this.TahBilgileriniGetirBtn.Name = "TahBilgileriniGetirBtn";
            this.TahBilgileriniGetirBtn.Size = new System.Drawing.Size(161, 23);
            this.TahBilgileriniGetirBtn.TabIndex = 3;
            this.TahBilgileriniGetirBtn.Text = "Tahsilat Bilgilerini Getir";
            this.TahBilgileriniGetirBtn.UseVisualStyleBackColor = true;
            this.TahBilgileriniGetirBtn.Click += new System.EventHandler(this.TahBilgileriniGetirBtn_Click);
            // 
            // RaporMusteriGetirCombo
            // 
            this.RaporMusteriGetirCombo.FormattingEnabled = true;
            this.RaporMusteriGetirCombo.Location = new System.Drawing.Point(210, 19);
            this.RaporMusteriGetirCombo.Name = "RaporMusteriGetirCombo";
            this.RaporMusteriGetirCombo.Size = new System.Drawing.Size(145, 21);
            this.RaporMusteriGetirCombo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Müşteri Seçiniz";
            // 
            // Tahsilat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 483);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tahsilat";
            this.Text = "Tahsilat İşlemleri";
            this.Load += new System.EventHandler(this.Tahsilat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tahsilat_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox aciklamabox;
        private System.Windows.Forms.TextBox tutarbox;
        private System.Windows.Forms.ComboBox UrunCombo;
        private System.Windows.Forms.ComboBox HizmetCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MusteriCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button KayitekleBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button TahBilgileriniGetirBtn;
        private System.Windows.Forms.ComboBox RaporMusteriGetirCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}