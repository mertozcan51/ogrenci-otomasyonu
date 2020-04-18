namespace EmreOdev2
{
    partial class ders_kayit
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
            this.vazgec = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.togretmen = new System.Windows.Forms.TextBox();
            this.tdadi = new System.Windows.Forms.TextBox();
            this.tdkodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vazgec
            // 
            this.vazgec.Location = new System.Drawing.Point(154, 143);
            this.vazgec.Name = "vazgec";
            this.vazgec.Size = new System.Drawing.Size(60, 23);
            this.vazgec.TabIndex = 26;
            this.vazgec.Text = "VAZGEÇ";
            this.vazgec.UseVisualStyleBackColor = true;
            this.vazgec.Click += new System.EventHandler(this.vazgec_Click);
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(73, 143);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(65, 23);
            this.kaydet.TabIndex = 25;
            this.kaydet.Text = "KAYDET";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // togretmen
            // 
            this.togretmen.Location = new System.Drawing.Point(82, 73);
            this.togretmen.Name = "togretmen";
            this.togretmen.Size = new System.Drawing.Size(132, 20);
            this.togretmen.TabIndex = 22;
            // 
            // tdadi
            // 
            this.tdadi.Location = new System.Drawing.Point(82, 47);
            this.tdadi.Name = "tdadi";
            this.tdadi.Size = new System.Drawing.Size(132, 20);
            this.tdadi.TabIndex = 21;
            // 
            // tdkodu
            // 
            this.tdkodu.Location = new System.Drawing.Point(82, 21);
            this.tdkodu.Name = "tdkodu";
            this.tdkodu.Size = new System.Drawing.Size(132, 20);
            this.tdkodu.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Öğretmen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ders Adi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ders Kodu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ders_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 199);
            this.Controls.Add(this.vazgec);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.togretmen);
            this.Controls.Add(this.tdadi);
            this.Controls.Add(this.tdkodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ders_kayit";
            this.Text = "ders_kayit";
            this.Load += new System.EventHandler(this.ders_kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vazgec;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.TextBox togretmen;
        private System.Windows.Forms.TextBox tdadi;
        private System.Windows.Forms.TextBox tdkodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}