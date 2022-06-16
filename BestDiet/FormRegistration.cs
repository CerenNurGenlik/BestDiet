using BusinessLogicLayer.Services;
using Model.Entites;
using Model.Enums;
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
    public partial class FormRegistration : Form
    {
        UserService userService;
        public FormRegistration()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            User user = userService.GetUserByUserName(txtEmail.Text.Trim());
            if(user != null)
            {
                MessageBox.Show("Böyle bir maile sahip kullanıcı mevcut!!!");
                return;
            }
            if(txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifre tekrarı hatalı");
                return;
            }
            try 
            {
                user = new User();
                user.FirstName = txtIsim.Text.Trim();
                user.LastName = txtSoyisim.Text.Trim();
                user.UserID = txtEmail.Text.Trim();
                user.Gender = rdbErkek.Checked ? Gender.Male : Gender.Female;
                user.BirthDate = dtpDogumTarihi.Value;
                user.Height = (int)nudBoy.Value;
                user.Weight = (double)nudKilo.Value;
                user.TargetWeight = (double)nudHedefKilo.Value;
                user.Password = txtSifre.Text;
                if (userService.InsertUser(user))
                {
                    MessageBox.Show("Kayıt başarılı ! ! !");

                }
                else throw new Exception("Kayıt esnasında bir hata oluştu :(");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
