using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Context;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class UrunEklemeEkrani : Form
    {
        public UrunEklemeEkrani()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        UrunDbContext dbContext = new UrunDbContext();

        private void UrunEklemeEkrani_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.Uruns.ToList();
        }
        void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var tbl = new Urun();
            tbl.UrunAdı = txtAd.Text;
            tbl.SatisFiyati = int.Parse(txtSatis.Text);
            tbl.StokMiktar = 0;
            tbl.BarkodNo = int.Parse(txtKod.Text);
            dbContext.Uruns.Add(tbl);
            dbContext.SaveChanges();
            MessageBox.Show("eklendi");
            Temizle();
            dataGridView1.DataSource = dbContext.Uruns.ToList();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSatis.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtKod.Text);
            var tbl = dbContext.Uruns.FirstOrDefault(x=>x.BarkodNo==ID);
            tbl.UrunAdı = txtAd.Text;
            tbl.SatisFiyati = int.Parse(txtSatis.Text);
            tbl.BarkodNo = int.Parse(txtKod.Text);
            dbContext.SaveChanges();
            MessageBox.Show("Guncellendi");
            Temizle();
            dataGridView1.DataSource = dbContext.Uruns.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            var tbl = dbContext.Uruns.FirstOrDefault(x => x.BarkodNo == ID);
            dbContext.Uruns.Remove(tbl);
            dbContext.SaveChanges();
            MessageBox.Show("Kayit silindi");
            Temizle();
            dataGridView1.DataSource = dbContext.Uruns.ToList();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in dbContext.Uruns select x;
            if (textBox.Text != null)
            {
                dataGridView1.DataSource = ara.Where(x => x.UrunAdı.Contains(textBox.Text)).ToList();
            }
        }
    }
}
