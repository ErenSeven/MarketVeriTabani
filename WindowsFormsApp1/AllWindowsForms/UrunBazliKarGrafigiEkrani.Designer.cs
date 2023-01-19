namespace WindowsFormsApp1.AllWindowsForms
{
    partial class UrunBazliKarGrafigiEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.urunBazliKarVeritabanıDataSet = new WindowsFormsApp1.UrunBazliKarVeritabanıDataSet();
            this.urunBazliKarVeritabanıDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunBazliKarVeritabanıDataSet1 = new WindowsFormsApp1.UrunBazliKarVeritabanıDataSet1();
            this.mydbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbTableAdapter = new WindowsFormsApp1.UrunBazliKarVeritabanıDataSet1TableAdapters.mydbTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBazliKarVeritabanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBazliKarVeritabanıDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBazliKarVeritabanıDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(134, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 30);
            this.label1.TabIndex = 63;
            this.label1.Text = "Ürün Bazlı Kar Grafiği";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.karMiktariDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mydbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(139, 156);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(526, 534);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(76, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 53);
            this.button1.TabIndex = 61;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(716, 156);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "UrunAdi";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "KarMiktari";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(601, 534);
            this.chart1.TabIndex = 64;
            this.chart1.Text = "chart1";
            // 
            // urunBazliKarVeritabanıDataSet
            // 
            this.urunBazliKarVeritabanıDataSet.DataSetName = "UrunBazliKarVeritabanıDataSet";
            this.urunBazliKarVeritabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunBazliKarVeritabanıDataSetBindingSource
            // 
            this.urunBazliKarVeritabanıDataSetBindingSource.DataSource = this.urunBazliKarVeritabanıDataSet;
            this.urunBazliKarVeritabanıDataSetBindingSource.Position = 0;
            // 
            // urunBazliKarVeritabanıDataSet1
            // 
            this.urunBazliKarVeritabanıDataSet1.DataSetName = "UrunBazliKarVeritabanıDataSet1";
            this.urunBazliKarVeritabanıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mydbBindingSource
            // 
            this.mydbBindingSource.DataMember = "mydb";
            this.mydbBindingSource.DataSource = this.urunBazliKarVeritabanıDataSet1;
            // 
            // mydbTableAdapter
            // 
            this.mydbTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // karMiktariDataGridViewTextBoxColumn
            // 
            this.karMiktariDataGridViewTextBoxColumn.DataPropertyName = "KarMiktari";
            this.karMiktariDataGridViewTextBoxColumn.HeaderText = "KarMiktari";
            this.karMiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.karMiktariDataGridViewTextBoxColumn.Name = "karMiktariDataGridViewTextBoxColumn";
            this.karMiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(770, 712);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 40);
            this.button2.TabIndex = 65;
            this.button2.Text = "Yükle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UrunBazliKarGrafigiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1416, 832);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "UrunBazliKarGrafigiEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunBazliKarGrafigiEkrani";
            this.Load += new System.EventHandler(this.UrunBazliKarGrafigiEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBazliKarVeritabanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBazliKarVeritabanıDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBazliKarVeritabanıDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource urunBazliKarVeritabanıDataSetBindingSource;
        private UrunBazliKarVeritabanıDataSet urunBazliKarVeritabanıDataSet;
        private UrunBazliKarVeritabanıDataSet1 urunBazliKarVeritabanıDataSet1;
        private System.Windows.Forms.BindingSource mydbBindingSource;
        private UrunBazliKarVeritabanıDataSet1TableAdapters.mydbTableAdapter mydbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn karMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}