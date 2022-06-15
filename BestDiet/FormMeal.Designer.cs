namespace BestDiet
{
    partial class FormMeal
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpUrunListesi = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpOgunTarihi = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYeniUrunEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblToplamKalori = new System.Windows.Forms.Label();
            this.grpAlinanKalori = new System.Windows.Forms.GroupBox();
            this.grpEklenenUrunler = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpUrunListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.grpAlinanKalori.SuspendLayout();
            this.grpEklenenUrunler.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BestDiet.Properties.Resources.Screenshot_9;
            this.pictureBox2.Location = new System.Drawing.Point(530, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // grpUrunListesi
            // 
            this.grpUrunListesi.Controls.Add(this.listView1);
            this.grpUrunListesi.Controls.Add(this.dtpOgunTarihi);
            this.grpUrunListesi.Controls.Add(this.pictureBox1);
            this.grpUrunListesi.Controls.Add(this.btnEkle);
            this.grpUrunListesi.Controls.Add(this.numericUpDown2);
            this.grpUrunListesi.Controls.Add(this.label2);
            this.grpUrunListesi.Controls.Add(this.numericUpDown1);
            this.grpUrunListesi.Controls.Add(this.label3);
            this.grpUrunListesi.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpUrunListesi.Location = new System.Drawing.Point(28, 77);
            this.grpUrunListesi.Name = "grpUrunListesi";
            this.grpUrunListesi.Size = new System.Drawing.Size(575, 375);
            this.grpUrunListesi.TabIndex = 24;
            this.grpUrunListesi.TabStop = false;
            this.grpUrunListesi.Text = "Ürün Listesi";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 30);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(352, 337);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "Kalori (kcal)";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 1;
            this.columnHeader5.Text = "Kategori";
            this.columnHeader5.Width = 83;
            // 
            // dtpOgunTarihi
            // 
            this.dtpOgunTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOgunTarihi.Location = new System.Drawing.Point(386, 188);
            this.dtpOgunTarihi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtpOgunTarihi.Name = "dtpOgunTarihi";
            this.dtpOgunTarihi.Size = new System.Drawing.Size(154, 27);
            this.dtpOgunTarihi.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(386, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(386, 330);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(150, 37);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(478, 282);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(61, 27);
            this.numericUpDown2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Sayısı:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(478, 235);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 27);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 285);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porsiyon:";
            // 
            // btnYeniUrunEkle
            // 
            this.btnYeniUrunEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnYeniUrunEkle.Location = new System.Drawing.Point(345, 33);
            this.btnYeniUrunEkle.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnYeniUrunEkle.Name = "btnYeniUrunEkle";
            this.btnYeniUrunEkle.Size = new System.Drawing.Size(165, 32);
            this.btnYeniUrunEkle.TabIndex = 22;
            this.btnYeniUrunEkle.Text = "Yeni Ürün Ekle";
            this.btnYeniUrunEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(386, 204);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(154, 39);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(386, 142);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(154, 39);
            this.btnDuzenle.TabIndex = 8;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BestDiet.Properties.Resources.Screenshot_10;
            this.pictureBox3.Location = new System.Drawing.Point(74, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lblToplamKalori
            // 
            this.lblToplamKalori.AutoSize = true;
            this.lblToplamKalori.BackColor = System.Drawing.Color.White;
            this.lblToplamKalori.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKalori.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblToplamKalori.Location = new System.Drawing.Point(17, 48);
            this.lblToplamKalori.Name = "lblToplamKalori";
            this.lblToplamKalori.Size = new System.Drawing.Size(50, 33);
            this.lblToplamKalori.TabIndex = 3;
            this.lblToplamKalori.Text = "560";
            // 
            // grpAlinanKalori
            // 
            this.grpAlinanKalori.BackColor = System.Drawing.Color.White;
            this.grpAlinanKalori.Controls.Add(this.pictureBox3);
            this.grpAlinanKalori.Controls.Add(this.lblToplamKalori);
            this.grpAlinanKalori.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAlinanKalori.Location = new System.Drawing.Point(386, 30);
            this.grpAlinanKalori.Name = "grpAlinanKalori";
            this.grpAlinanKalori.Size = new System.Drawing.Size(150, 102);
            this.grpAlinanKalori.TabIndex = 10;
            this.grpAlinanKalori.TabStop = false;
            this.grpAlinanKalori.Text = "Toplam Kalori";
            // 
            // grpEklenenUrunler
            // 
            this.grpEklenenUrunler.Controls.Add(this.grpAlinanKalori);
            this.grpEklenenUrunler.Controls.Add(this.btnSil);
            this.grpEklenenUrunler.Controls.Add(this.btnDuzenle);
            this.grpEklenenUrunler.Controls.Add(this.listView2);
            this.grpEklenenUrunler.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpEklenenUrunler.Location = new System.Drawing.Point(28, 460);
            this.grpEklenenUrunler.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grpEklenenUrunler.Name = "grpEklenenUrunler";
            this.grpEklenenUrunler.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grpEklenenUrunler.Size = new System.Drawing.Size(575, 253);
            this.grpEklenenUrunler.TabIndex = 23;
            this.grpEklenenUrunler.TabStop = false;
            this.grpEklenenUrunler.Text = "Eklenen Ürünler";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(8, 32);
            this.listView2.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(349, 211);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Adı";
            this.columnHeader3.Width = 149;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 2;
            this.columnHeader4.Text = "Kalori (kcal)";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 1;
            this.columnHeader6.Text = "Kategori";
            this.columnHeader6.Width = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ürün Ara:";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(112, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 27);
            this.textBox1.TabIndex = 20;
            // 
            // FormMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(635, 734);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpUrunListesi);
            this.Controls.Add(this.btnYeniUrunEkle);
            this.Controls.Add(this.grpEklenenUrunler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMeal";
            this.Text = "FormMeal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpUrunListesi.ResumeLayout(false);
            this.grpUrunListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.grpAlinanKalori.ResumeLayout(false);
            this.grpAlinanKalori.PerformLayout();
            this.grpEklenenUrunler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpUrunListesi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.DateTimePicker dtpOgunTarihi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYeniUrunEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblToplamKalori;
        private System.Windows.Forms.GroupBox grpAlinanKalori;
        private System.Windows.Forms.GroupBox grpEklenenUrunler;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}