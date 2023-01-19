﻿using System;
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
    public partial class UrunBazliKarGrafigiEkrani : Form
    {
        private UrunDbContext dbContext = new UrunDbContext();

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

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "UrunAdı";
            chart1.Series[0].YValueMembers = "StokMiktar";

            //chart1.Series[1].XValueMember = "Ürün Adı";
            //chart1.Series[1].YValueMembers = "Ürün Adı";

            //chart1.Series[2].XValueMember = "Ürün Adı";
            //chart1.Series[2].YValueMembers = "Ürün Adı";

            //chart1.DataSource = urunBazliKarVeritabanıDataSet1.mydb;
            chart1.DataSource = dbContext.Uruns.ToList();
            chart1.DataBind();
        }
    }
}
