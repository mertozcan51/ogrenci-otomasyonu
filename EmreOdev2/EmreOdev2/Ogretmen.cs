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
    public partial class Ogretmen : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        private static string connectionString = ConfigurationManager.ConnectionStrings["EmreOdev"].ConnectionString;
        int ekle = 1;
        int upt = 2;
        DataTable dt ;
        
        public void getir()
        {
            baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            da = new SqlDataAdapter("Select  * from ogretmen",baglanti);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public Ogretmen()
        {
            InitializeComponent();
            getir();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            dt = new DataTable();
            string sorgu = "select * from ogretmen where hadi like '%"+textBox1.Text+"%' ";
            SqlDataAdapter ara = new SqlDataAdapter(sorgu,baglanti);
            ara.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ogretmen_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'emreOdevDataSet.ogretmen' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogretmenTableAdapter.Fill(this.emreOdevDataSet.ogretmen);

        }

        private void kayit_Click(object sender, EventArgs e)
        {
            ogrtmn_kayit frm = new ogrtmn_kayit();
            frm.deger = ekle;
            frm.ShowDialog();
            
        }

        private void gor_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
           
            ogrtmn_kayit frm = new ogrtmn_kayit();
            frm.id = id;
            frm.deger = upt;
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            string sorgu = "Delete from ogretmen where Id='"+id+"'";
            baglanti.Open();
            komut = new SqlCommand(sorgu,baglanti);
            SqlDataReader dr  ;
            dr = komut.ExecuteReader();
            baglanti.Close();
            getir();
             
        }
    }
}
