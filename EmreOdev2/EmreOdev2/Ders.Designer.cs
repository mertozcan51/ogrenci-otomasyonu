namespace EmreOdev2
{
    partial class Ders
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
            this.emreOdevDataSet2 = new EmreOdev2.EmreOdevDataSet2();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersTableAdapter = new EmreOdev2.EmreOdevDataSet2TableAdapters.dersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emreOdevDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(442, 105);
            this.dataGridView1.TabIndex = 17;
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(195, 60);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(75, 23);
            this.kayit.TabIndex = 16;
            this.kayit.Text = "Yeni Kayit";
            this.kayit.UseVisualStyleBackColor = true;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(105, 60);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 15;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // gor
            // 
            this.gor.Location = new System.Drawing.Point(12, 60);
            this.gor.Name = "gor";
            this.gor.Size = new System.Drawing.Size(75, 23);
            this.gor.TabIndex = 14;
            this.gor.Text = "Gör";
            this.gor.UseVisualStyleBackColor = true;
            this.gor.Click += new System.EventHandler(this.gor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ARA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emreOdevDataSet2
            // 
            this.emreOdevDataSet2.DataSetName = "EmreOdevDataSet2";
            this.emreOdevDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "ders";
            this.dersBindingSource.DataSource = this.emreOdevDataSet2;
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // Ders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 224);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.gor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Ders";
            this.Text = "Ders";
            this.Load += new System.EventHandler(this.Ders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emreOdevDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
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
        private EmreOdevDataSet2 emreOdevDataSet2;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private EmreOdevDataSet2TableAdapters.dersTableAdapter dersTableAdapter;
    }
}