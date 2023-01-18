using System;
using System.Windows.Forms;
using WindowsFormsApp1.AllWindowsForms;

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

        private void button6_Click(object sender, EventArgs e)
        {
            MusteriEklemeEkrani musteriEklemeEkrani = new MusteriEklemeEkrani();
            musteriEklemeEkrani.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RaporlamaAnaEkrani raporlamaAnaEkrani = new RaporlamaAnaEkrani();
            raporlamaAnaEkrani.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaticiBorcuOdemeEkrani saticiBorcuOdemeEkrani = new SaticiBorcuOdemeEkrani();
            saticiBorcuOdemeEkrani.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriBorcuOdemeEkrani musteriBorcuOdemeEkrani = new MusteriBorcuOdemeEkrani();
            musteriBorcuOdemeEkrani.Show();
            this.Hide();
        }
    }
}
