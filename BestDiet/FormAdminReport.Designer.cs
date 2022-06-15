namespace BestDiet
{
    partial class FormAdminReport
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
            this.lvRapor = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRaporTipi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvRapor
            // 
            this.lvRapor.HideSelection = false;
            this.lvRapor.Location = new System.Drawing.Point(42, 110);
            this.lvRapor.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.lvRapor.Name = "lvRapor";
            this.lvRapor.Size = new System.Drawing.Size(699, 458);
            this.lvRapor.TabIndex = 5;
            this.lvRapor.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rapor Tipi";
            // 
            // cmbRaporTipi
            // 
            this.cmbRaporTipi.FormattingEnabled = true;
            this.cmbRaporTipi.Location = new System.Drawing.Point(146, 39);
            this.cmbRaporTipi.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.cmbRaporTipi.Name = "cmbRaporTipi";
            this.cmbRaporTipi.Size = new System.Drawing.Size(255, 28);
            this.cmbRaporTipi.TabIndex = 3;
            // 
            // FormAdminReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 613);
            this.Controls.Add(this.lvRapor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRaporTipi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAdminReport";
            this.Text = "FormAdminReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvRapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRaporTipi;
    }
}