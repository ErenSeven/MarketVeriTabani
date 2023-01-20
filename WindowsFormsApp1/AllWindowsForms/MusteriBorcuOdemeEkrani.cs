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
    public partial class MusteriBorcuOdemeEkrani : Form
    {
        public MusteriBorcuOdemeEkrani()
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
        private void MusteriBorcuOdemeEkrani_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.Musteris.ToList();
            dataGridView2.DataSource = dbContext.Satis.ToList();
        }
        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID2 = int.Parse(textBox1.Text);
            var tbl3 = dbContext.Musteris.FirstOrDefault(x => x.MusteriID == ID2);
            tbl3.MusteriOdeme += decimal.Parse(textBox4.Text);
            tbl3.GuncelBorc = tbl3.MusteriBorc - tbl3.MusteriOdeme;
            dbContext.SaveChanges();
            MessageBox.Show("Borc silindi");
            dataGridView1.DataSource = dbContext.Musteris.ToList();
            dataGridView2.DataSource = dbContext.Satis.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int SatID = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            int UrnID = int.Parse(dataGridView2.CurrentRow.Cells[1].Value.ToString());

            int MusID = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            var Sat = dbContext.Satis.FirstOrDefault(x => x.SatisID == SatID);
            var Urn = dbContext.Uruns.FirstOrDefault(x => x.UrunID == UrnID);
            var Mus = dbContext.Musteris.FirstOrDefault(x => x.MusteriID == MusID);
            Mus.MusteriBorc -= Urn.SatisFiyati * Sat.SatisMiktar;

            dbContext.Satis.Remove(Sat);
            dbContext.SaveChanges();
            MessageBox.Show("Satın alma silindi");
            dataGridView1.DataSource = dbContext.Musteris.ToList();
            dataGridView2.DataSource = dbContext.Satis.ToList();
        }
    }
}
