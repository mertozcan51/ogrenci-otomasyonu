namespace EmreOdev2
{
    partial class ogr_kayit
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
            this.tsifre = new System.Windows.Forms.TextBox();
            this.tposta = new System.Windows.Forms.TextBox();
            this.tno = new System.Windows.Forms.TextBox();
            this.tsoyadi = new System.Windows.Forms.TextBox();
            this.tadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vazgec
            // 
            this.vazgec.Location = new System.Drawing.Point(142, 197);
            this.vazgec.Name = "vazgec";
            this.vazgec.Size = new System.Drawing.Size(60, 23);
            this.vazgec.TabIndex = 26;
            this.vazgec.Text = "VAZGEÇ";
            this.vazgec.UseVisualStyleBackColor = true;
            this.vazgec.Click += new System.EventHandler(this.vazgec_Click);
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(59, 197);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(65, 23);
            this.kaydet.TabIndex = 25;
            this.kaydet.Text = "KAYDET";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // tsifre
            // 
            this.tsifre.Location = new System.Drawing.Point(70, 129);
            this.tsifre.Name = "tsifre";
            this.tsifre.Size = new System.Drawing.Size(132, 20);
            this.tsifre.TabIndex = 24;
            // 
            // tposta
            // 
            this.tposta.Location = new System.Drawing.Point(70, 103);
            this.tposta.Name = "tposta";
            this.tposta.Size = new System.Drawing.Size(132, 20);
            this.tposta.TabIndex = 23;
            // 
            // tno
            // 
            this.tno.Location = new System.Drawing.Point(70, 77);
            this.tno.Name = "tno";
            this.tno.Size = new System.Drawing.Size(132, 20);
            this.tno.TabIndex = 22;
            // 
            // tsoyadi
            // 
            this.tsoyadi.Location = new System.Drawing.Point(70, 51);
            this.tsoyadi.Name = "tsoyadi";
            this.tsoyadi.Size = new System.Drawing.Size(132, 20);
            this.tsoyadi.TabIndex = 21;
            // 
            // tadi
            // 
            this.tadi.Location = new System.Drawing.Point(70, 25);
            this.tadi.Name = "tadi";
            this.tadi.Size = new System.Drawing.Size(132, 20);
            this.tadi.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "E-Posta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ögr No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyadi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adi:";
            // 
            // ogr_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 271);
            this.Controls.Add(this.vazgec);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.tsifre);
            this.Controls.Add(this.tposta);
            this.Controls.Add(this.tno);
            this.Controls.Add(this.tsoyadi);
            this.Controls.Add(this.tadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ogr_kayit";
            this.Text = "ogr_kayit";
            this.Load += new System.EventHandler(this.ogr_kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vazgec;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.TextBox tsifre;
        private System.Windows.Forms.TextBox tposta;
        private System.Windows.Forms.TextBox tno;
        private System.Windows.Forms.TextBox tsoyadi;
        private System.Windows.Forms.TextBox tadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}