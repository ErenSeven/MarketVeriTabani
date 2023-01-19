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
    public partial class UrunBazliKarGrafigiEkrani : Form
    {
        public UrunBazliKarGrafigiEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaporlamaAnaEkrani raporlamaAnaEkrani = new RaporlamaAnaEkrani();
            raporlamaAnaEkrani.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UrunBazliKarGrafigiEkrani_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'urunBazliKarVeritabanıDataSet1.mydb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mydbTableAdapter.Fill(this.urunBazliKarVeritabanıDataSet1.mydb);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "UrunAdi";
            chart1.Series[0].YValueMembers = "KarMiktari";    

            //chart1.Series[1].XValueMember = "Ürün Adı";
            //chart1.Series[1].YValueMembers = "Ürün Adı";

            //chart1.Series[2].XValueMember = "Ürün Adı";
            //chart1.Series[2].YValueMembers = "Ürün Adı";

            chart1.DataSource = urunBazliKarVeritabanıDataSet1.mydb;
            chart1.DataBind();
        }
    }
}
