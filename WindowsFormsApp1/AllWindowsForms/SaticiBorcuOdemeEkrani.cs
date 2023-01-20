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
    public partial class SaticiBorcuOdemeEkrani : Form
    {
        public SaticiBorcuOdemeEkrani()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void SaticiBorcuOdemeEkrani_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.Kullanicis.ToList();
            dataGridView2.DataSource = dbContext.Tedarikcis.ToList();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int ID2 = int.Parse(textBox2.Text);
            var tbl3 = dbContext.Kullanicis.FirstOrDefault(x => x.KullaniciID == ID2);
            tbl3.Borc -= decimal.Parse(textBox4.Text);
            dbContext.SaveChanges();

            int ID3 = int.Parse(textBox1.Text);
            var tbl4 = dbContext.Tedarikcis.FirstOrDefault(x => x.TedarikciID == ID3);
            tbl4.Alacak -= decimal.Parse(textBox4.Text);
            dbContext.SaveChanges();

            MessageBox.Show("Borc silindi");
            dataGridView1.DataSource = dbContext.Kullanicis.ToList();
            dataGridView2.DataSource = dbContext.Tedarikcis.ToList();


        }
    }
}
