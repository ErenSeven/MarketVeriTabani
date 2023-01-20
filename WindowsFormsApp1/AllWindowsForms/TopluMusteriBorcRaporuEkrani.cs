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


namespace WindowsFormsApp1
{
    public partial class TopluMusteriBorcRaporuEkrani : Form
    {
        UrunDbContext dbContext = new UrunDbContext();

        public TopluMusteriBorcRaporuEkrani()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RaporlamaAnaEkrani raporlamaAnaEkrani = new RaporlamaAnaEkrani();
            raporlamaAnaEkrani.Show();
            this.Hide();
        }

        private void TopluMusteriBorcRaporuEkrani_Load(object sender, EventArgs e)
        {
            var liste = from x in dbContext.Musteris
                        select new
                        {   
                            x.Ad,
                            x.SoyAd,
                            x.MusteriBorc,
                            x.MusteriOdeme                         

                        };

            var orderByResult = from s in liste
                                orderby s.MusteriOdeme
                                select s;

            var MusterisInDescOrder = orderByResult.OrderByDescending(s => s.MusteriOdeme);

            dataGridView1.DataSource = MusterisInDescOrder.ToList();
        }
    }
}
