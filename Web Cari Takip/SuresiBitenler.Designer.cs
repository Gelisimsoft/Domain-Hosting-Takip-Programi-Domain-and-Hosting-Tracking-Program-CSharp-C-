namespace Domain_Hosting
{
    partial class SuresiBitenler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuresiBitenler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HostinglistBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DomainlistBox = new System.Windows.Forms.ListBox();
            this.HostingSuresiLbl = new System.Windows.Forms.Label();
            this.DomainSuresiLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HostingSuresiLbl);
            this.groupBox1.Controls.Add(this.HostinglistBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hosting";
            // 
            // HostinglistBox
            // 
            this.HostinglistBox.FormattingEnabled = true;
            this.HostinglistBox.Location = new System.Drawing.Point(6, 19);
            this.HostinglistBox.Name = "HostinglistBox";
            this.HostinglistBox.Size = new System.Drawing.Size(276, 316);
            this.HostinglistBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DomainSuresiLbl);
            this.groupBox2.Controls.Add(this.DomainlistBox);
            this.groupBox2.Location = new System.Drawing.Point(306, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 343);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Domain";
            // 
            // DomainlistBox
            // 
            this.DomainlistBox.FormattingEnabled = true;
            this.DomainlistBox.Location = new System.Drawing.Point(7, 19);
            this.DomainlistBox.Name = "DomainlistBox";
            this.DomainlistBox.Size = new System.Drawing.Size(276, 316);
            this.DomainlistBox.TabIndex = 0;
            // 
            // HostingSuresiLbl
            // 
            this.HostingSuresiLbl.AutoSize = true;
            this.HostingSuresiLbl.BackColor = System.Drawing.Color.White;
            this.HostingSuresiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HostingSuresiLbl.ForeColor = System.Drawing.Color.Red;
            this.HostingSuresiLbl.Location = new System.Drawing.Point(12, 153);
            this.HostingSuresiLbl.Name = "HostingSuresiLbl";
            this.HostingSuresiLbl.Size = new System.Drawing.Size(0, 13);
            this.HostingSuresiLbl.TabIndex = 1;
            // 
            // DomainSuresiLbl
            // 
            this.DomainSuresiLbl.AutoSize = true;
            this.DomainSuresiLbl.BackColor = System.Drawing.Color.White;
            this.DomainSuresiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DomainSuresiLbl.ForeColor = System.Drawing.Color.Red;
            this.DomainSuresiLbl.Location = new System.Drawing.Point(11, 153);
            this.DomainSuresiLbl.Name = "DomainSuresiLbl";
            this.DomainSuresiLbl.Size = new System.Drawing.Size(0, 13);
            this.DomainSuresiLbl.TabIndex = 1;
            this.DomainSuresiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SuresiBitenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuresiBitenler";
            this.Text = "Hosting ve Domain Yenileme Süresi Yaklaşanlar";
            this.Load += new System.EventHandler(this.SuresiBitenler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox HostinglistBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox DomainlistBox;
        private System.Windows.Forms.Label HostingSuresiLbl;
        private System.Windows.Forms.Label DomainSuresiLbl;
    }
}