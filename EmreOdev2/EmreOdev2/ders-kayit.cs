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
    public partial class ders_kayit : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        private static string connectionString = ConfigurationManager.ConnectionStrings["EmreOdev"].ConnectionString;
        public int id { get; set; }
        public int deger { get; set; }
        public void doldur()
        {
              

            baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sorgu = "select * from ders where Id='" + id + "'";
            komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                tdadi.Text = dr["dersadi"].ToString();
                tdkodu.Text = dr["derskodu"].ToString();
                togretmen.Text = dr["ogretmen"].ToString();
                 

            }
            baglanti.Close();
        }
        public ders_kayit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ders_kayit_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (deger == 1)
            {
                string dersadi = tdadi.Text;
                string derskodu = tdkodu.Text;
                string ogretmen = togretmen.Text;

                string sorgu = "Insert into ders (dersadi, derskodu, ogretmen ) Values ('" + dersadi + "','" + derskodu + "','" + ogretmen + "')";
                komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                Ders frm = (Ders)Application.OpenForms["Ders"];
                frm.getir();
            }
            if (deger == 2)
            {

                string dersadi = tdadi.Text;
                string derskodu = tdkodu.Text;
                string ogretmen = togretmen.Text;
              
                string sorgu = "Update ders set dersadi='" + dersadi + "',derskodu='" + derskodu + "',ogretmen='" + ogretmen + "' where Id='" + id + "' ";
                komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
               Ders frm = (Ders)Application.OpenForms["Ders"];
                frm.getir();

            }
            baglanti.Close();
            this.Close();
        }

        private void vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
