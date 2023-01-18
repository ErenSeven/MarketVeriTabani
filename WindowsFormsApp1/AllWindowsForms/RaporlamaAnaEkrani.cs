using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AllWindowsForms;

namespace WindowsFormsApp1
{
    public partial class RaporlamaAnaEkrani : Form
    {
        public RaporlamaAnaEkrani()
        {
            InitializeComponent();
        }

        private void RaporlamaAnaEkrani_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TopluMusteriBorcRaporuEkrani topluMusteriBorcRaporuEkrani = new TopluMusteriBorcRaporuEkrani();
            topluMusteriBorcRaporuEkrani.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaticiKarZararRaporuEkrani saticiKarZararRaporuEkrani = new SaticiKarZararRaporuEkrani();
            saticiKarZararRaporuEkrani.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UrunBazliKarRaporuEkrani urunBazliKarRaporuEkrani = new UrunBazliKarRaporuEkrani();
            urunBazliKarRaporuEkrani.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunBazliKarGrafigiEkrani urunBazliKarGrafigiEkrani = new UrunBazliKarGrafigiEkrani();
            urunBazliKarGrafigiEkrani.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriBazliRaporEkrani musteriBazliRaporEkrani = new MusteriBazliRaporEkrani();
            musteriBazliRaporEkrani.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SatisTrendiEkrani satisTrendiEkrani = new SatisTrendiEkrani();
            satisTrendiEkrani.Show();
            this.Hide();
        }
    }
}
