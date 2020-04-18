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
    public partial class ogr_kayit : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        private static string connectionString = ConfigurationManager.ConnectionStrings["EmreOdev"].ConnectionString;
        public int id { get; set; }
        public int deger { get; set; }
        public void doldur()
        {
            Console.WriteLine("gelen" + id);


            baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sorgu = "select * from ogrenci where Id='" + id + "'";
            komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                tadi.Text = dr["oadi"].ToString();
                tsoyadi.Text = dr["osoyadi"].ToString();
                tno.Text = dr["numara"].ToString();
                tposta.Text = dr["posta"].ToString();
                tsifre.Text = dr["sifre"].ToString();

            }
            baglanti.Close();
        }
        public ogr_kayit()
        {
            InitializeComponent();
        }

        private void ogr_kayit_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (deger == 1)
            {
                string adi = tadi.Text;
                string soyadi = tsoyadi.Text;
                string numara = tno.Text;
                string posta = tposta.Text;
                string sifre = tsifre.Text;
                string sorgu = "Insert into ogrenci (oadi, osoyadi, numara, posta, sifre) Values ('" + adi + "','" + soyadi + "','" + numara + "','" + posta + "','" + sifre + "')";
                komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                Ogrenci frm = (Ogrenci)Application.OpenForms["Ogrenci"];
                frm.getir();
            }
            if (deger == 2)
            {

                string adi = tadi.Text;
                string soyadi = tsoyadi.Text;
                string numara = tno.Text;
                string posta = tposta.Text;
                string sifre = tsifre.Text;
                string sorgu = "Update ogrenci set oadi='" + adi + "',osoyadi='" + soyadi + "',numara='" + numara + "',posta='" + posta + "',sifre='" + sifre + "' where Id='" + id + "' ";
                komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                Ogrenci frm = (Ogrenci)Application.OpenForms["Ogrenci"];
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
