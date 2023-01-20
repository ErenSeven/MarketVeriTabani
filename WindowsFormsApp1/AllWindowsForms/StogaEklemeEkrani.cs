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

namespace WindowsFormsApp1
{
    public partial class StogaEklemeEkrani : Form
    {
        public StogaEklemeEkrani()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        UrunDbContext dbContext = new UrunDbContext();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void StogaEklemeEkrani_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.Uruns.ToList();
            dataGridView2.DataSource = dbContext.Tedarikcis.ToList();
            dataGridView3.DataSource = dbContext.Kullanicis.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tbl = new Irsaliye();
            tbl.GirdiBirimFiyat = int.Parse(txtBirim.Text);
            tbl.TedarikciNo = int.Parse(textNo.Text);
            tbl.UrunKod = int.Parse(txtKod.Text);
            tbl.Miktar = int.Parse(txtMiktar.Text);
            tbl.KullaniciKod = int.Parse(textBox1.Text);
            dbContext.Irsaliyes.Add(tbl);
            dbContext.SaveChanges();
            MessageBox.Show("eklendi");


            int ID = int.Parse(txtKod.Text);
            var tbl2 = dbContext.Uruns.FirstOrDefault(x => x.BarkodNo == ID);
            tbl2.StokMiktar += int.Parse(txtMiktar.Text);
            dbContext.SaveChanges();
            
            int ID4 = int.Parse(txtKod.Text);
            var tbl5 = dbContext.Uruns.FirstOrDefault(x => x.BarkodNo == ID4);
            tbl5.Kar = tbl5.SatisFiyati - tbl.GirdiBirimFiyat;
            dbContext.SaveChanges();

            int ID2 = int.Parse(textNo.Text);
            var tbl3 = dbContext.Tedarikcis.FirstOrDefault(x => x.TedarikciID == ID2);
            tbl3.Alacak += (decimal.Parse(txtBirim.Text))*(decimal.Parse(txtMiktar.Text));
            dbContext.SaveChanges();

            int ID3 = int.Parse(textBox1.Text);
            var tbl4 = dbContext.Kullanicis.FirstOrDefault(x => x.KullaniciID == ID3);
            tbl4.Borc += (decimal.Parse(txtBirim.Text)) * (decimal.Parse(txtMiktar.Text));
            dbContext.SaveChanges();


            dataGridView1.DataSource = dbContext.Uruns.ToList();
            dataGridView2.DataSource = dbContext.Tedarikcis.ToList();
            dataGridView3.DataSource = dbContext.Kullanicis.ToList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textNo.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
