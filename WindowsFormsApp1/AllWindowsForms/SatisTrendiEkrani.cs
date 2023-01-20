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
                            d1.UrunID,
                            d1.UrunAdı,
                            d1.ToplamSatis
                        };
            var orderByResult = from s in sorgu
                                orderby s.ToplamSatis
                                select s;
            var UrunsInDescOrder = orderByResult.OrderByDescending(s => s.ToplamSatis);

            dataGridView1.DataSource = UrunsInDescOrder.ToList();
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
            
        
        }
    }
}
