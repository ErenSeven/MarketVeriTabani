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
    public partial class TedarikciEkleme : Form
    {
        public TedarikciEkleme()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        UrunDbContext dbContext = new UrunDbContext();
        private void TedarikciEkleme_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.Tedarikcis.ToList();
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
            var tbl = new Tedarikci();
            tbl.TedarikciAd = txtAd.Text;
            dbContext.Tedarikcis.Add(tbl);
            dbContext.SaveChanges();
            MessageBox.Show("eklendi");
            Temizle();
            dataGridView1.DataSource = dbContext.Tedarikcis.ToList();
        }

       
    }
}
