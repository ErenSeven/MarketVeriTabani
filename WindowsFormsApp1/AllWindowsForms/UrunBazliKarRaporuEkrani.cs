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
    public partial class UrunBazliKarRaporuEkrani : Form
    {
        UrunDbContext dbContext = new UrunDbContext();

        public UrunBazliKarRaporuEkrani()
        {
            InitializeComponent();
        }
              
       

        private void button1_Click(object sender, EventArgs e)
        {
            RaporlamaAnaEkrani raporlamaAnaEkrani = new RaporlamaAnaEkrani();
            raporlamaAnaEkrani.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UrunBazliKarRaporuEkrani_Load(object sender, EventArgs e)
        {
            var liste = from x in dbContext.Uruns
                        select new
                        {
                            x.UrunAdı,
                            x.Kar
                        };

                
            dataGridView1.DataSource = liste.ToList();
            // dataGridView1.Sort(dataGridView1.Columns["Kar"], ListSortDirection.Ascending);
            //dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
            // dataGridView1.Columns[1].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            // dataGridView1.Sort(dataGridView1.Columns["Kar"],ListSortDirection.Descending);

        }
    }
}
