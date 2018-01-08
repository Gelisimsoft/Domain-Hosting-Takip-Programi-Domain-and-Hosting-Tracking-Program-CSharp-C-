namespace Domain_Hosting
{
    partial class EPosta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EPosta));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Maillist = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unvanbtn = new System.Windows.Forms.Button();
            this.unvanlist = new System.Windows.Forms.ListBox();
            this.Unvanbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PostaEkle = new System.Windows.Forms.Button();
            this.EpostaSifre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EpostaAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Maillist);
            this.groupBox2.Location = new System.Drawing.Point(191, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 172);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Firma Adına Kayıtlı E - Posta Hesapları";
            // 
            // Maillist
            // 
            this.Maillist.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Maillist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Maillist.ForeColor = System.Drawing.Color.White;
            this.Maillist.FormattingEnabled = true;
            this.Maillist.Location = new System.Drawing.Point(6, 19);
            this.Maillist.Name = "Maillist";
            this.Maillist.Size = new System.Drawing.Size(200, 147);
            this.Maillist.TabIndex = 0;
            this.Maillist.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unvanbtn);
            this.groupBox1.Controls.Add(this.unvanlist);
            this.groupBox1.Controls.Add(this.Unvanbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 287);
            this.groupBox1.TabIndex = 7;
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
            this.unvanlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.unvanlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unvanlist.FormattingEnabled = true;
            this.unvanlist.Location = new System.Drawing.Point(6, 71);
            this.unvanlist.Name = "unvanlist";
            this.unvanlist.Size = new System.Drawing.Size(161, 212);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.PostaEkle);
            this.groupBox3.Controls.Add(this.EpostaSifre);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.EpostaAd);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(191, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 109);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "E - Posta Ekle";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(115, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PostaEkle
            // 
            this.PostaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PostaEkle.Location = new System.Drawing.Point(7, 69);
            this.PostaEkle.Name = "PostaEkle";
            this.PostaEkle.Size = new System.Drawing.Size(91, 36);
            this.PostaEkle.TabIndex = 15;
            this.PostaEkle.Text = "GÜNCELLE";
            this.PostaEkle.UseVisualStyleBackColor = true;
            this.PostaEkle.Click += new System.EventHandler(this.PostaEkle_Click);
            // 
            // EpostaSifre
            // 
            this.EpostaSifre.Location = new System.Drawing.Point(44, 43);
            this.EpostaSifre.Name = "EpostaSifre";
            this.EpostaSifre.Size = new System.Drawing.Size(162, 20);
            this.EpostaSifre.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Şifre";
            // 
            // EpostaAd
            // 
            this.EpostaAd.Location = new System.Drawing.Point(44, 17);
            this.EpostaAd.Name = "EpostaAd";
            this.EpostaAd.Size = new System.Drawing.Size(162, 20);
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
            // EPosta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 305);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EPosta";
            this.Text = "E - Posta Raporlama ve Güncelleme";
            this.Load += new System.EventHandler(this.EPosta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EPosta_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox Maillist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button unvanbtn;
        private System.Windows.Forms.ListBox unvanlist;
        private System.Windows.Forms.TextBox Unvanbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PostaEkle;
        private System.Windows.Forms.TextBox EpostaSifre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EpostaAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}