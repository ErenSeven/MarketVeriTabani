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
            dbContext.Irsaliyes.Add(tbl);
            dbContext.SaveChanges();
            MessageBox.Show("eklendi");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textNo.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
