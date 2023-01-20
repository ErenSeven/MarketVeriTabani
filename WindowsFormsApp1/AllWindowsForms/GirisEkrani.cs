using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Context;

namespace WindowsFormsApp1.AllWindowsForms
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Kaydol kaydol = new Kaydol();
            kaydol.Show();
            this.Hide();
        }
        UrunDbContext dbContext = new UrunDbContext();
        private void button1_Click(object sender, EventArgs e)
        {

            string kullaniciAdi = textBox3.Text;
            var tbl = dbContext.Kullanicis.FirstOrDefault(x => x.Ad == kullaniciAdi);
            string sifre = textBox5.Text;
            var tbl2 = dbContext.Kullanicis.FirstOrDefault(x => x.Sifre == sifre);
            if (tbl==null||tbl2==null)
            {
                MessageBox.Show("Lütfen geçerli bir kullanıcı girin");
                
            }
            else
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                context.Database.Create();
                MessageBox.Show("Database oluşturuldu.");
            }
        }
    }
}
