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
    public partial class MusteriEklemeEkrani : Form
    {
        public MusteriEklemeEkrani()
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

        private void MusteriEklemeEkrani_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.Musteris.ToList();
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
            var tbl = new Musteri();
            tbl.Ad = txtAd.Text;
            tbl.SoyAd = textBox1.Text;
            dbContext.Musteris.Add(tbl);
            dbContext.SaveChanges();
            MessageBox.Show("eklendi");
            Temizle();
            dataGridView1.DataSource = dbContext.Musteris.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            var tbl = dbContext.Musteris.FirstOrDefault(x => x.MusteriID == ID);
            dbContext.Musteris.Remove(tbl);
            dbContext.SaveChanges();
            MessageBox.Show("Kayit silindi");
            Temizle();
            dataGridView1.DataSource = dbContext.Musteris.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
