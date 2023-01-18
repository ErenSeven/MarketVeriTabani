using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SatisEkrani : Form
    {
        public SatisEkrani()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 anaEkran = new Form1();
            anaEkran.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CariSatisEkrani cariSatisEkrani = new CariSatisEkrani();
            cariSatisEkrani.Show();
            this.Hide();
        }
    }
}
