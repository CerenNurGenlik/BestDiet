namespace BestDiet
{
    partial class FormActivity
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
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.lvEklenenAktiviteler = new System.Windows.Forms.ListView();
            this.grpAlinanKalori = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAktiviteToplamKalori = new System.Windows.Forms.Label();
            this.grpEklenenUrunler = new System.Windows.Forms.GroupBox();
            this.btnAktiviteEkle = new System.Windows.Forms.Button();
            this.dtpOgunTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAktiviteler = new System.Windows.Forms.ListView();
            this.grpAktiviteListesi = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtAktiviteAra = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpAlinanKalori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpEklenenUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpAktiviteListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Aktivite Ara:";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kalori (kcal)";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Aktivite Adı";
            this.columnHeader3.Width = 230;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(482, 255);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(192, 49);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(482, 178);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(192, 49);
            this.btnDuzenle.TabIndex = 8;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // lvEklenenAktiviteler
            // 
            this.lvEklenenAktiviteler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvEklenenAktiviteler.HideSelection = false;
            this.lvEklenenAktiviteler.Location = new System.Drawing.Point(10, 40);
            this.lvEklenenAktiviteler.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.lvEklenenAktiviteler.Name = "lvEklenenAktiviteler";
            this.lvEklenenAktiviteler.Size = new System.Drawing.Size(435, 263);
            this.lvEklenenAktiviteler.TabIndex = 7;
            this.lvEklenenAktiviteler.UseCompatibleStateImageBehavior = false;
            this.lvEklenenAktiviteler.View = System.Windows.Forms.View.Details;
            // 
            // grpAlinanKalori
            // 
            this.grpAlinanKalori.BackColor = System.Drawing.Color.White;
            this.grpAlinanKalori.Controls.Add(this.pictureBox1);
            this.grpAlinanKalori.Controls.Add(this.lblAktiviteToplamKalori);
            this.grpAlinanKalori.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAlinanKalori.Location = new System.Drawing.Point(482, 38);
            this.grpAlinanKalori.Margin = new System.Windows.Forms.Padding(4);
            this.grpAlinanKalori.Name = "grpAlinanKalori";
            this.grpAlinanKalori.Padding = new System.Windows.Forms.Padding(4);
            this.grpAlinanKalori.Size = new System.Drawing.Size(188, 128);
            this.grpAlinanKalori.TabIndex = 10;
            this.grpAlinanKalori.TabStop = false;
            this.grpAlinanKalori.Text = "Toplam Kalori";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BestDiet.Properties.Resources.Screenshot_8;
            this.pictureBox1.Location = new System.Drawing.Point(92, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblAktiviteToplamKalori
            // 
            this.lblAktiviteToplamKalori.AutoSize = true;
            this.lblAktiviteToplamKalori.BackColor = System.Drawing.Color.White;
            this.lblAktiviteToplamKalori.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktiviteToplamKalori.ForeColor = System.Drawing.Color.Red;
            this.lblAktiviteToplamKalori.Location = new System.Drawing.Point(21, 60);
            this.lblAktiviteToplamKalori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAktiviteToplamKalori.Name = "lblAktiviteToplamKalori";
            this.lblAktiviteToplamKalori.Size = new System.Drawing.Size(41, 28);
            this.lblAktiviteToplamKalori.TabIndex = 3;
            this.lblAktiviteToplamKalori.Text = "560";
            // 
            // grpEklenenUrunler
            // 
            this.grpEklenenUrunler.Controls.Add(this.grpAlinanKalori);
            this.grpEklenenUrunler.Controls.Add(this.btnSil);
            this.grpEklenenUrunler.Controls.Add(this.btnDuzenle);
            this.grpEklenenUrunler.Controls.Add(this.lvEklenenAktiviteler);
            this.grpEklenenUrunler.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpEklenenUrunler.Location = new System.Drawing.Point(15, 568);
            this.grpEklenenUrunler.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.grpEklenenUrunler.Name = "grpEklenenUrunler";
            this.grpEklenenUrunler.Padding = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.grpEklenenUrunler.Size = new System.Drawing.Size(719, 316);
            this.grpEklenenUrunler.TabIndex = 29;
            this.grpEklenenUrunler.TabStop = false;
            this.grpEklenenUrunler.Text = "Eklenen Aktiviteler";
            // 
            // btnAktiviteEkle
            // 
            this.btnAktiviteEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAktiviteEkle.Location = new System.Drawing.Point(411, 34);
            this.btnAktiviteEkle.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.btnAktiviteEkle.Name = "btnAktiviteEkle";
            this.btnAktiviteEkle.Size = new System.Drawing.Size(206, 40);
            this.btnAktiviteEkle.TabIndex = 28;
            this.btnAktiviteEkle.Text = "Aktivite Ekle";
            this.btnAktiviteEkle.UseVisualStyleBackColor = true;
            this.btnAktiviteEkle.Click += new System.EventHandler(this.btnAktiviteEkle_Click);
            // 
            // dtpOgunTarihi
            // 
            this.dtpOgunTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOgunTarihi.Location = new System.Drawing.Point(482, 198);
            this.dtpOgunTarihi.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dtpOgunTarihi.Name = "dtpOgunTarihi";
            this.dtpOgunTarihi.Size = new System.Drawing.Size(192, 23);
            this.dtpOgunTarihi.TabIndex = 12;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(482, 396);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(188, 46);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aktivite Süresi (dk)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(539, 318);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 23);
            this.numericUpDown1.TabIndex = 10;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kalori (kcal)";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Aktivite Adı";
            this.columnHeader1.Width = 230;
            // 
            // lvAktiviteler
            // 
            this.lvAktiviteler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvAktiviteler.HideSelection = false;
            this.lvAktiviteler.Location = new System.Drawing.Point(6, 38);
            this.lvAktiviteler.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.lvAktiviteler.Name = "lvAktiviteler";
            this.lvAktiviteler.Size = new System.Drawing.Size(439, 420);
            this.lvAktiviteler.TabIndex = 1;
            this.lvAktiviteler.UseCompatibleStateImageBehavior = false;
            this.lvAktiviteler.View = System.Windows.Forms.View.Details;
            // 
            // grpAktiviteListesi
            // 
            this.grpAktiviteListesi.Controls.Add(this.pictureBox3);
            this.grpAktiviteListesi.Controls.Add(this.lvAktiviteler);
            this.grpAktiviteListesi.Controls.Add(this.dtpOgunTarihi);
            this.grpAktiviteListesi.Controls.Add(this.btnEkle);
            this.grpAktiviteListesi.Controls.Add(this.label2);
            this.grpAktiviteListesi.Controls.Add(this.numericUpDown1);
            this.grpAktiviteListesi.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpAktiviteListesi.Location = new System.Drawing.Point(15, 89);
            this.grpAktiviteListesi.Margin = new System.Windows.Forms.Padding(4);
            this.grpAktiviteListesi.Name = "grpAktiviteListesi";
            this.grpAktiviteListesi.Padding = new System.Windows.Forms.Padding(4);
            this.grpAktiviteListesi.Size = new System.Drawing.Size(719, 469);
            this.grpAktiviteListesi.TabIndex = 30;
            this.grpAktiviteListesi.TabStop = false;
            this.grpAktiviteListesi.Text = "Aktivite Listesi";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BestDiet.Properties.Resources.Screenshot_13;
            this.pictureBox3.Location = new System.Drawing.Point(482, 21);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 168);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // txtAktiviteAra
            // 
            this.txtAktiviteAra.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAktiviteAra.Location = new System.Drawing.Point(138, 35);
            this.txtAktiviteAra.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.txtAktiviteAra.Name = "txtAktiviteAra";
            this.txtAktiviteAra.Size = new System.Drawing.Size(254, 23);
            this.txtAktiviteAra.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BestDiet.Properties.Resources.Screenshot_12;
            this.pictureBox2.Location = new System.Drawing.Point(635, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // FormActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 909);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpEklenenUrunler);
            this.Controls.Add(this.btnAktiviteEkle);
            this.Controls.Add(this.grpAktiviteListesi);
            this.Controls.Add(this.txtAktiviteAra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormActivity";
            this.Text = "FormActivity";
            this.Load += new System.EventHandler(this.FormActivity_Load);
            this.grpAlinanKalori.ResumeLayout(false);
            this.grpAlinanKalori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpEklenenUrunler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpAktiviteListesi.ResumeLayout(false);
            this.grpAktiviteListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.ListView lvEklenenAktiviteler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpAlinanKalori;
        private System.Windows.Forms.Label lblAktiviteToplamKalori;
        private System.Windows.Forms.GroupBox grpEklenenUrunler;
        private System.Windows.Forms.Button btnAktiviteEkle;
        private System.Windows.Forms.DateTimePicker dtpOgunTarihi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView lvAktiviteler;
        private System.Windows.Forms.GroupBox grpAktiviteListesi;
        private System.Windows.Forms.TextBox txtAktiviteAra;
    }
}