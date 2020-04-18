namespace EmreOdev2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ogretmen = new System.Windows.Forms.Button();
            this.ogrenci = new System.Windows.Forms.Button();
            this.dersler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ogretmen
            // 
            this.ogretmen.BackColor = System.Drawing.Color.DarkGray;
            this.ogretmen.Location = new System.Drawing.Point(40, 25);
            this.ogretmen.Name = "ogretmen";
            this.ogretmen.Size = new System.Drawing.Size(154, 66);
            this.ogretmen.TabIndex = 0;
            this.ogretmen.Text = "ÖĞRETMENLER";
            this.ogretmen.UseVisualStyleBackColor = false;
            this.ogretmen.Click += new System.EventHandler(this.ogretmen_Click);
            // 
            // ogrenci
            // 
            this.ogrenci.BackColor = System.Drawing.Color.DarkGray;
            this.ogrenci.Location = new System.Drawing.Point(40, 97);
            this.ogrenci.Name = "ogrenci";
            this.ogrenci.Size = new System.Drawing.Size(154, 66);
            this.ogrenci.TabIndex = 1;
            this.ogrenci.Text = "ÖĞRENCİLER";
            this.ogrenci.UseVisualStyleBackColor = false;
            this.ogrenci.Click += new System.EventHandler(this.ogrenci_Click);
            // 
            // dersler
            // 
            this.dersler.BackColor = System.Drawing.Color.DarkGray;
            this.dersler.Location = new System.Drawing.Point(40, 169);
            this.dersler.Name = "dersler";
            this.dersler.Size = new System.Drawing.Size(154, 66);
            this.dersler.TabIndex = 2;
            this.dersler.Text = "DERSLER";
            this.dersler.UseVisualStyleBackColor = false;
            this.dersler.Click += new System.EventHandler(this.dersler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 247);
            this.Controls.Add(this.dersler);
            this.Controls.Add(this.ogrenci);
            this.Controls.Add(this.ogretmen);
            this.Name = "Form1";
            this.Text = "EMRE KARABIYIK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ogretmen;
        private System.Windows.Forms.Button ogrenci;
        private System.Windows.Forms.Button dersler;
    }
}

