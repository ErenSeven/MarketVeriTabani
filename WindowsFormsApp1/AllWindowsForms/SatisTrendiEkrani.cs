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
    public partial class SatisTrendiEkrani : Form
    {
        public SatisTrendiEkrani()
        {
            InitializeComponent();
        }
        UrunDbContext dbContext = new UrunDbContext();
        private void SatisTrendiEkrani_Load(object sender, EventArgs e)
        {
            var sorgu = from d1 in dbContext.Uruns
                        select new
                        {
                            d1.BarkodNo,
                            d1.UrunAdı,
                            d1.ToplamSatis
                        };
            var orderByResult = from s in sorgu
                                orderby s.ToplamSatis
                                select s;
            var UrunsInDescOrder = orderByResult.OrderByDescending(s => s.ToplamSatis);

            dataGridView1.DataSource = UrunsInDescOrder.ToList();

            var grafik = from d1 in dbContext.Satis
                         where d1.UrunKodu == 1
                         select new
                         {
                             d1.SatisTarih,
                             d1.SatisMiktar
                         };

            chart1.Series[0].XValueMember = "SatisTarih";
            chart1.Series[0].YValueMembers = "SatisMiktar";

            chart1.DataSource = grafik.ToList();
            chart1.DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaporlamaAnaEkrani raporlamaAnaEkrani = new RaporlamaAnaEkrani();
            raporlamaAnaEkrani.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());


            var grafik = from d1 in dbContext.Satis
                        where d1.UrunKodu == ID
                        select new
                        {
                            d1.SatisTarih,
                            d1.SatisMiktar                            
                        };

            chart1.Series[0].XValueMember = "SatisTarih";
            chart1.Series[0].YValueMembers = "SatisMiktar";

            chart1.DataSource = grafik.ToList();
            chart1.DataBind();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
