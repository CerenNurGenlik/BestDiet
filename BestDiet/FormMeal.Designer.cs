﻿namespace BestDiet
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
            this.lvYiyecekler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpOgunTarihi = new System.Windows.Forms.DateTimePicker();
            this.pbYemekResmi = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.nudPorsiyon = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudUrunSayisi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYeniUrunEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblToplamKalori = new System.Windows.Forms.Label();
            this.grpAlinanKalori = new System.Windows.Forms.GroupBox();
            this.grpEklenenUrunler = new System.Windows.Forms.GroupBox();
            this.lvEklenenYiyecekler = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtYiyecekAra = new System.Windows.Forms.TextBox();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOgunAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpUrunListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbYemekResmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsiyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.grpAlinanKalori.SuspendLayout();
            this.grpEklenenUrunler.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BestDiet.Properties.Resources.Screenshot_9;
            this.pictureBox2.Location = new System.Drawing.Point(698, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // grpUrunListesi
            // 
            this.grpUrunListesi.Controls.Add(this.lvYiyecekler);
            this.grpUrunListesi.Controls.Add(this.dtpOgunTarihi);
            this.grpUrunListesi.Controls.Add(this.pbYemekResmi);
            this.grpUrunListesi.Controls.Add(this.btnEkle);
            this.grpUrunListesi.Controls.Add(this.nudPorsiyon);
            this.grpUrunListesi.Controls.Add(this.label2);
            this.grpUrunListesi.Controls.Add(this.nudUrunSayisi);
            this.grpUrunListesi.Controls.Add(this.label3);
            this.grpUrunListesi.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpUrunListesi.Location = new System.Drawing.Point(28, 77);
            this.grpUrunListesi.Name = "grpUrunListesi";
            this.grpUrunListesi.Size = new System.Drawing.Size(743, 375);
            this.grpUrunListesi.TabIndex = 24;
            this.grpUrunListesi.TabStop = false;
            this.grpUrunListesi.Text = "Yiyecek Listesi";
            // 
            // lvYiyecekler
            // 
            this.lvYiyecekler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.lvYiyecekler.FullRowSelect = true;
            this.lvYiyecekler.HideSelection = false;
            this.lvYiyecekler.Location = new System.Drawing.Point(5, 30);
            this.lvYiyecekler.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.lvYiyecekler.Name = "lvYiyecekler";
            this.lvYiyecekler.Size = new System.Drawing.Size(492, 337);
            this.lvYiyecekler.TabIndex = 1;
            this.lvYiyecekler.UseCompatibleStateImageBehavior = false;
            this.lvYiyecekler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 188;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "Kalori (kcal)";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 1;
            this.columnHeader5.Text = "Kategori";
            this.columnHeader5.Width = 139;
            // 
            // dtpOgunTarihi
            // 
            this.dtpOgunTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOgunTarihi.Location = new System.Drawing.Point(555, 188);
            this.dtpOgunTarihi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtpOgunTarihi.Name = "dtpOgunTarihi";
            this.dtpOgunTarihi.Size = new System.Drawing.Size(154, 27);
            this.dtpOgunTarihi.TabIndex = 12;
            // 
            // pbYemekResmi
            // 
            this.pbYemekResmi.Location = new System.Drawing.Point(555, 30);
            this.pbYemekResmi.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.pbYemekResmi.Name = "pbYemekResmi";
            this.pbYemekResmi.Size = new System.Drawing.Size(154, 128);
            this.pbYemekResmi.TabIndex = 3;
            this.pbYemekResmi.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(555, 330);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(150, 37);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // nudPorsiyon
            // 
            this.nudPorsiyon.Location = new System.Drawing.Point(647, 282);
            this.nudPorsiyon.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nudPorsiyon.Name = "nudPorsiyon";
            this.nudPorsiyon.Size = new System.Drawing.Size(61, 27);
            this.nudPorsiyon.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Sayısı:";
            // 
            // nudUrunSayisi
            // 
            this.nudUrunSayisi.Location = new System.Drawing.Point(647, 235);
            this.nudUrunSayisi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nudUrunSayisi.Name = "nudUrunSayisi";
            this.nudUrunSayisi.Size = new System.Drawing.Size(61, 27);
            this.nudUrunSayisi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 285);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porsiyon:";
            // 
            // btnYeniUrunEkle
            // 
            this.btnYeniUrunEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnYeniUrunEkle.Location = new System.Drawing.Point(28, 23);
            this.btnYeniUrunEkle.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnYeniUrunEkle.Name = "btnYeniUrunEkle";
            this.btnYeniUrunEkle.Size = new System.Drawing.Size(165, 32);
            this.btnYeniUrunEkle.TabIndex = 22;
            this.btnYeniUrunEkle.Text = "Yeni Ürün Ekle";
            this.btnYeniUrunEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(555, 206);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(154, 39);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(555, 144);
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
            this.pictureBox3.Location = new System.Drawing.Point(73, 39);
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
            this.grpAlinanKalori.Location = new System.Drawing.Point(555, 32);
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
            this.grpEklenenUrunler.Controls.Add(this.lvEklenenYiyecekler);
            this.grpEklenenUrunler.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpEklenenUrunler.Location = new System.Drawing.Point(28, 460);
            this.grpEklenenUrunler.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grpEklenenUrunler.Name = "grpEklenenUrunler";
            this.grpEklenenUrunler.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grpEklenenUrunler.Size = new System.Drawing.Size(743, 253);
            this.grpEklenenUrunler.TabIndex = 23;
            this.grpEklenenUrunler.TabStop = false;
            this.grpEklenenUrunler.Text = "Eklenen Yiyecekler";
            // 
            // lvEklenenYiyecekler
            // 
            this.lvEklenenYiyecekler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader7});
            this.lvEklenenYiyecekler.FullRowSelect = true;
            this.lvEklenenYiyecekler.HideSelection = false;
            this.lvEklenenYiyecekler.Location = new System.Drawing.Point(8, 32);
            this.lvEklenenYiyecekler.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.lvEklenenYiyecekler.Name = "lvEklenenYiyecekler";
            this.lvEklenenYiyecekler.Size = new System.Drawing.Size(489, 211);
            this.lvEklenenYiyecekler.TabIndex = 7;
            this.lvEklenenYiyecekler.UseCompatibleStateImageBehavior = false;
            this.lvEklenenYiyecekler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Adı";
            this.columnHeader3.Width = 172;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Porsiyon";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ürün Sayısı";
            this.columnHeader6.Width = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(213, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Yiyecek Ara:";
            // 
            // txtYiyecekAra
            // 
            this.txtYiyecekAra.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtYiyecekAra.Location = new System.Drawing.Point(321, 23);
            this.txtYiyecekAra.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtYiyecekAra.Name = "txtYiyecekAra";
            this.txtYiyecekAra.Size = new System.Drawing.Size(204, 27);
            this.txtYiyecekAra.TabIndex = 20;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kalori(kcal)";
            this.columnHeader7.Width = 110;
            // 
            // lblOgunAdi
            // 
            this.lblOgunAdi.AutoSize = true;
            this.lblOgunAdi.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgunAdi.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOgunAdi.Location = new System.Drawing.Point(571, 26);
            this.lblOgunAdi.Name = "lblOgunAdi";
            this.lblOgunAdi.Size = new System.Drawing.Size(71, 24);
            this.lblOgunAdi.TabIndex = 26;
            this.lblOgunAdi.Text = "Öğün Adı";
            // 
            // FormMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 734);
            this.Controls.Add(this.lblOgunAdi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpUrunListesi);
            this.Controls.Add(this.btnYeniUrunEkle);
            this.Controls.Add(this.grpEklenenUrunler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYiyecekAra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMeal";
            this.Text = "FormMeal";
            this.Load += new System.EventHandler(this.FormMeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpUrunListesi.ResumeLayout(false);
            this.grpUrunListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbYemekResmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsiyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunSayisi)).EndInit();
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
        private System.Windows.Forms.ListView lvYiyecekler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.DateTimePicker dtpOgunTarihi;
        private System.Windows.Forms.PictureBox pbYemekResmi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.NumericUpDown nudPorsiyon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudUrunSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYeniUrunEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblToplamKalori;
        private System.Windows.Forms.GroupBox grpAlinanKalori;
        private System.Windows.Forms.GroupBox grpEklenenUrunler;
        private System.Windows.Forms.ListView lvEklenenYiyecekler;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYiyecekAra;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lblOgunAdi;
    }
}