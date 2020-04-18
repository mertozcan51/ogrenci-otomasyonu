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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ogretmen_Click(object sender, EventArgs e)
        {
            Ogretmen frm = new Ogretmen();
            frm.ShowDialog();
        }

        private void dersler_Click(object sender, EventArgs e)
        {
            Ders frm = new Ders();
            frm.ShowDialog();
        }

        private void ogrenci_Click(object sender, EventArgs e)
        {
            Ogrenci frm = new Ogrenci();
            frm.ShowDialog();
        }
    }
}
