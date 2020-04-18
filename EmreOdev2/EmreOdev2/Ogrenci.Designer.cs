namespace EmreOdev2
{
    partial class Ogrenci
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kayit = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.gor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.emreOdevDataSet1 = new EmreOdev2.EmreOdevDataSet1();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter = new EmreOdev2.EmreOdevDataSet1TableAdapters.ogrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emreOdevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(449, 105);
            this.dataGridView1.TabIndex = 11;
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(195, 80);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(82, 23);
            this.kayit.TabIndex = 10;
            this.kayit.Text = "Yeni Kayit";
            this.kayit.UseVisualStyleBackColor = true;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(100, 80);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(82, 23);
            this.sil.TabIndex = 9;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // gor
            // 
            this.gor.Location = new System.Drawing.Point(12, 80);
            this.gor.Name = "gor";
            this.gor.Size = new System.Drawing.Size(82, 23);
            this.gor.TabIndex = 8;
            this.gor.Text = "Gör";
            this.gor.UseVisualStyleBackColor = true;
            this.gor.Click += new System.EventHandler(this.gor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ARA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emreOdevDataSet1
            // 
            this.emreOdevDataSet1.DataSetName = "EmreOdevDataSet1";
            this.emreOdevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "ogrenci";
            this.ogrenciBindingSource.DataSource = this.emreOdevDataSet1;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 281);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.gor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Ogrenci";
            this.Text = "Ogrenci";
            this.Load += new System.EventHandler(this.Ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emreOdevDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button gor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private EmreOdevDataSet1 emreOdevDataSet1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private EmreOdevDataSet1TableAdapters.ogrenciTableAdapter ogrenciTableAdapter;
    }
}