using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CariSatisEkrani : Form
    {
        public CariSatisEkrani()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SatisEkrani satisEkrani = new SatisEkrani();
            satisEkrani.Show();
            this.Hide();
        }
    }
}
