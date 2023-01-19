namespace WindowsFormsApp1.AllWindowsForms
{
    partial class UrunBazliKarRaporuEkrani
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
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.urunBazliKarVeritabanıDataSet = new WindowsFormsApp1.UrunBazliKarVeritabanıDataSet();
            this.mydbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbTableAdapter = new WindowsFormsApp1.UrunBazliKarVeritabanıDataSetTableAdapters.mydbTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBazliKarVeritabanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(53, -82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 30);
            this.label6.TabIndex = 57;
            this.label6.Text = "Ürün Bazlı Kar Raporu";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(-5, -169);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 53);
            this.button3.TabIndex = 55;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(140, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 30);
            this.label1.TabIndex = 60;
            this.label1.Text = "Ürün Bazlı Kar Raporu";
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
            this.dataGridView1.Location = new System.Drawing.Point(145, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(748, 652);
            this.dataGridView1.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(82, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 53);
            this.button1.TabIndex = 58;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // urunBazliKarVeritabanıDataSet
            // 
            this.urunBazliKarVeritabanıDataSet.DataSetName = "UrunBazliKarVeritabanıDataSet";
            this.urunBazliKarVeritabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mydbBindingSource
            // 
            this.mydbBindingSource.DataMember = "mydb";
            this.mydbBindingSource.DataSource = this.urunBazliKarVeritabanıDataSet;
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
            // UrunBazliKarRaporuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1416, 832);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Name = "UrunBazliKarRaporuEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunBazliKarRaporuEkrani";
            this.Load += new System.EventHandler(this.UrunBazliKarRaporuEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBazliKarVeritabanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private UrunBazliKarVeritabanıDataSet urunBazliKarVeritabanıDataSet;
        private System.Windows.Forms.BindingSource mydbBindingSource;
        private UrunBazliKarVeritabanıDataSetTableAdapters.mydbTableAdapter mydbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn karMiktariDataGridViewTextBoxColumn;
    }
}