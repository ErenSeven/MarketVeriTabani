using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.AllWindowsForms
{
    public partial class UrunBazliKarRaporuEkrani : Form
    {
        public UrunBazliKarRaporuEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaporlamaAnaEkrani raporlamaAnaEkrani = new RaporlamaAnaEkrani();
            raporlamaAnaEkrani.Show();
            this.Hide();
        }

        private void UrunBazliKarRaporuEkrani_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'urunBazliKarVeritabanıDataSet.mydb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mydbTableAdapter.Fill(this.urunBazliKarVeritabanıDataSet.mydb);

        }
    }
}
