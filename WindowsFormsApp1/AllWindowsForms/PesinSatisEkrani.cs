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
    public partial class PesinSatisEkrani : Form
    {
        public PesinSatisEkrani()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SatisEkrani satisEkrani = new SatisEkrani();
            satisEkrani.Show();
            this.Hide();
        }

        UrunDbContext dbContext = new UrunDbContext();
        private void PesinSatisEkrani_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.Uruns.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int ID = int.Parse(txtKod.Text);
            var tbl2 = dbContext.Uruns.FirstOrDefault(x => x.BarkodNo == ID);
            tbl2.StokMiktar -= int.Parse(txtSatis.Text);
            dbContext.SaveChanges();


            if (tbl2.StokMiktar <= 5)
            {
                MessageBox.Show("Stok 5'in altında.");
            }

            dataGridView1.DataSource = dbContext.Uruns.ToList();
        }
    }
}
