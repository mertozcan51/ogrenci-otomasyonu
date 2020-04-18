namespace EmreOdev2
{
    partial class Ogretmen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gor = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.kayit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emreOdevDataSet = new EmreOdev2.EmreOdevDataSet();
            this.ogretmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogretmenTableAdapter = new EmreOdev2.EmreOdevDataSetTableAdapters.ogretmenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emreOdevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gor
            // 
            this.gor.Location = new System.Drawing.Point(26, 60);
            this.gor.Name = "gor";
            this.gor.Size = new System.Drawing.Size(75, 23);
            this.gor.TabIndex = 2;
            this.gor.Text = "Gör";
            this.gor.UseVisualStyleBackColor = true;
            this.gor.Click += new System.EventHandler(this.gor_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(118, 60);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 3;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(209, 60);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(75, 23);
            this.kayit.TabIndex = 4;
            this.kayit.Text = "Yeni Kayit";
            this.kayit.UseVisualStyleBackColor = true;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(442, 105);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // emreOdevDataSet
            // 
            this.emreOdevDataSet.DataSetName = "EmreOdevDataSet";
            this.emreOdevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogretmenBindingSource
            // 
            this.ogretmenBindingSource.DataMember = "ogretmen";
            this.ogretmenBindingSource.DataSource = this.emreOdevDataSet;
            // 
            // ogretmenTableAdapter
            // 
            this.ogretmenTableAdapter.ClearBeforeFill = true;
            // 
            // Ogretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 202);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.gor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Ogretmen";
            this.Text = "Ogretmen";
            this.Load += new System.EventHandler(this.Ogretmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emreOdevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gor;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmreOdevDataSet emreOdevDataSet;
        private System.Windows.Forms.BindingSource ogretmenBindingSource;
        private EmreOdevDataSetTableAdapters.ogretmenTableAdapter ogretmenTableAdapter;
    }
}