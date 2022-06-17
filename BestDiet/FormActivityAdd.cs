using BusinessLogicLayer.Services;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestDiet
{
    public partial class FormActivityAdd : Form
    {
        SportService sportService;
        public FormActivityAdd()
        {
            InitializeComponent();
            sportService = new SportService();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Sport sport = new Sport();
                sport.SportName = txtAktiviteAdi.Text;
                sport.BurningCalori = Convert.ToInt32(nudKalori.Value);
                
                if (sportService.Insert(sport)) MessageBox.Show("Yeni aktivite eklendi");
                else throw new Exception("Aktivite ekleme esnasında bir hata oluştu :(");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
