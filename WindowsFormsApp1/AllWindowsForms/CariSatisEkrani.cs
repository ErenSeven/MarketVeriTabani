using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Context;

namespace WindowsFormsApp1
{
    public partial class CariSatisEkrani : Form
    {
        public CariSatisEkrani()
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
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void CariSatisEkrani_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.Uruns.ToList();
            dataGridView2.DataSource = dbContext.Musteris.ToList();
            dataGridView3.DataSource = dbContext.Satis.ToList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtKod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMus.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tbl = new Satis();
            tbl.MusteriNo = int.Parse(txtMus.Text);
            tbl.SatisMiktar = int.Parse(txtSatis.Text);
            tbl.UrunKodu = int.Parse(txtKod.Text);
            tbl.SatisTarih = dateTimePicker1.Value;
            dbContext.Satis.Add(tbl);
            dbContext.SaveChanges();
            MessageBox.Show("sepete eklendi");


            int ID = int.Parse(txtKod.Text);
            var tbl2 = dbContext.Uruns.FirstOrDefault(x => x.BarkodNo == ID);
            tbl2.StokMiktar -= int.Parse(txtSatis.Text);
            dbContext.SaveChanges();

            int ID2 = int.Parse(txtMus.Text);
            var tbl3 = dbContext.Musteris.FirstOrDefault(x => x.MusteriID == ID2);
            tbl3.MusteriBorc += ((decimal.Parse(txtSatis.Text))*(tbl2.SatisFiyati));
            dbContext.SaveChanges();

            dataGridView1.DataSource = dbContext.Uruns.ToList();
            dataGridView2.DataSource = dbContext.Musteris.ToList();

            if (tbl2.StokMiktar <= 5)
            {
                MessageBox.Show("Stok 5'in altında.");
            }

        }
    }
}
