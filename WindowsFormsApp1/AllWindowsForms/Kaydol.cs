using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Context;

namespace WindowsFormsApp1.AllWindowsForms
{
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }

        UrunDbContext dbContext = new UrunDbContext();

        private void button1_Click(object sender, EventArgs e)
        {
            var tbl = new Kullanici();
            tbl.Ad = txtAd.Text;
            tbl.Sifre = txtSifre.Text;
            dbContext.Kullanicis.Add(tbl);
            dbContext.SaveChanges();
            MessageBox.Show("Kullanıcı kaydoldu.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }
    }
}
