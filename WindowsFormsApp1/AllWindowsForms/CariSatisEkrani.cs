using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Context;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            tbl3.GuncelBorc = tbl3.MusteriBorc - tbl3.MusteriOdeme;
            dbContext.SaveChanges();

            dataGridView1.DataSource = dbContext.Uruns.ToList();
            dataGridView2.DataSource = dbContext.Musteris.ToList();
            dataGridView3.DataSource = dbContext.Satis.ToList();

            if (tbl2.StokMiktar <= 5)
            {
                MessageBox.Show("Stok 5'in altında.");
            }

        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int ID = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            var tbl = dbContext.Satis.FirstOrDefault(x => x.SatisID == ID);

            int ID3 = int.Parse(txtKod.Text);
            var tbl2 = dbContext.Uruns.FirstOrDefault(x => x.BarkodNo == ID3);
            int ID2 = int.Parse(txtMus.Text);
            var tbl3 = dbContext.Musteris.FirstOrDefault(x => x.MusteriID == ID2);

            string kullaniciAdi = textBox2.Text;
            var x1 = dbContext.Kullanicis.FirstOrDefault(x => x.Ad == kullaniciAdi);
            string kullanicisifre = textBox1.Text;
            var x2 = dbContext.Kullanicis.FirstOrDefault(x => x.Sifre == kullanicisifre);
            if (x1==null||x2==null)
            {
                MessageBox.Show("Lütfen geçerli bir kullanıcı girin");

            }
            else
            {
                tbl2.StokMiktar += int.Parse(txtSatis.Text);

                
                tbl3.MusteriBorc -= ((decimal.Parse(txtSatis.Text)) * (tbl2.SatisFiyati));
                tbl3.GuncelBorc = tbl3.MusteriBorc - tbl3.MusteriOdeme;

                dbContext.Satis.Remove(tbl);
                dbContext.SaveChanges();
                MessageBox.Show("Sepetten silindi");
                dataGridView1.DataSource = dbContext.Uruns.ToList();
                dataGridView2.DataSource = dbContext.Musteris.ToList();
                dataGridView3.DataSource = dbContext.Satis.ToList();
            }
            
        }
    }
}
