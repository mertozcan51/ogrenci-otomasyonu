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
    public partial class ogrtmn_kayit : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        private static string connectionString = ConfigurationManager.ConnectionStrings["EmreOdev"].ConnectionString;
        public int id { get; set; }
        public int deger { get; set; }
        public void doldur()
        {
            Console.WriteLine("gelen"+id);
            

            baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sorgu = "select * from ogretmen where Id='"+id+"'";
            komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                tadi.Text = dr["hadi"].ToString();
                tsoyadi.Text = dr["hsoyadi"].ToString();
                tunvan.Text = dr["unvan"].ToString();
                tposta.Text = dr["posta"].ToString();
                tsifre.Text = dr["sifre"].ToString();
                
            }
            baglanti.Close();
        }
        public ogrtmn_kayit()
        {
            InitializeComponent();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ogrtmn_kayit_Load(object sender, EventArgs e)
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
                string unvan = tunvan.Text;
                string posta = tposta.Text;
                string sifre = tsifre.Text;
                string sorgu = "Insert into ogretmen (hadi, hsoyadi, unvan, posta, sifre) Values ('"+adi+"','"+soyadi+"','"+unvan+"','"+posta+"','"+sifre+"')";
            komut = new SqlCommand(sorgu,baglanti);
            komut.ExecuteNonQuery();
                Ogretmen frm = (Ogretmen)Application.OpenForms["Ogretmen"];
                frm.getir();
             }
            if (deger==2)
            {

                string adi = tadi.Text;
                string soyadi = tsoyadi.Text;
                string unvan = tunvan.Text;
                string posta = tposta.Text;
                string sifre = tsifre.Text;
                string sorgu = "Update ogretmen set hadi='" + adi + "',hsoyadi='" + soyadi + "',unvan='" + unvan + "',posta='" + posta + "',sifre='" + sifre + "' where Id='"+id+"' ";
                komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                Ogretmen frm = (Ogretmen)Application.OpenForms["Ogretmen"];
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
