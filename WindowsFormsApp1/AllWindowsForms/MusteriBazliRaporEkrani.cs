﻿using System;
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
    public partial class MusteriBazliRaporEkrani : Form
    {
        public MusteriBazliRaporEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaporlamaAnaEkrani raporlamaAnaEkrani = new RaporlamaAnaEkrani();
            raporlamaAnaEkrani.Show();
            this.Hide();
        }

        private void MusteriBazliRaporEkrani_Load(object sender, EventArgs e)
        {
            // ürün adı toplam satış miktarı toplam tutar.
            // Müşteri seç
            // Müşteri, Uruns ve Satis tablosunu join le
            // müşteri adı toplam satış miktarı toplam tutar.
            // müşteri adı arama yapılıcak.
        }
    }
}
