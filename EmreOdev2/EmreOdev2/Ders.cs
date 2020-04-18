using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace EmreOdev2
{
    public partial class Ders : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        private static string connectionString = ConfigurationManager.ConnectionStrings["EmreOdev"].ConnectionString;
        int ekle = 1;
        int upt = 2;
        DataTable dt;
        public void getir()
        {
            baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            da = new SqlDataAdapter("Select *  from ders ", baglanti);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public Ders()
        {
            InitializeComponent();
            getir();

        }

        private void Ders_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'emreOdevDataSet2.ders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersTableAdapter.Fill(this.emreOdevDataSet2.ders);

        }

        private void kayit_Click(object sender, EventArgs e)
        {
            ders_kayit frm = new ders_kayit();
            frm.deger = ekle;
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            dt = new DataTable();
            string sorgu = "select * from ders where dersadi like '%" + textBox1.Text + "%' ";
            SqlDataAdapter ara = new SqlDataAdapter(sorgu, baglanti);
            ara.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }

        private void gor_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            ders_kayit frm = new ders_kayit();
            frm.id = id;
            frm.deger = upt;
            frm.ShowDialog();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            string sorgu = "Delete from ders where Id='" + id + "'";
            baglanti.Open();
            komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            baglanti.Close();
            getir();
        }
    }
}
