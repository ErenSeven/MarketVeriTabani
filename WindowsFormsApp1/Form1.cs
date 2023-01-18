using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SatisEkrani satisEkrani = new SatisEkrani();
            satisEkrani.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UrunEklemeEkrani urunEklemeEkrani = new UrunEklemeEkrani();
            urunEklemeEkrani.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StogaEklemeEkrani stogaEklemeEkrani = new StogaEklemeEkrani();
            stogaEklemeEkrani.Show();
            this.Hide();
        }
    }
}
