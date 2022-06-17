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
    public partial class FormUserMain : Form
    {
        User user;
        MealService mealService;
        ExerciseService exerciseService;
        WaterService waterService;
        MealCategoryService mealcategoryService;
        public FormUserMain(User _user)
        {
            InitializeComponent();
            user = _user;
            mealcategoryService = new MealCategoryService();
            waterService = new WaterService();
        }

        private void FormUserMain_Load(object sender, EventArgs e)
        {
            Helper.ClearControls(Controls);
            lblKullaniciAdi.Text = user.FirstName + " " + user.LastName;
            lblHedefKilo.Text=user.TargetWeight.ToString();
            lblKilo.Text = user.Weight.ToString();
            lblBoy.Text = user.Height.ToString();
            lblYas.Text = (DateTime.Now.Year - user.BirthDate.Year).ToString();

            int vki = Convert.ToInt32(user.Weight*10000 / Math.Pow(user.Height, 2));
            lblKitleIndeksi.Text = vki.ToString();

            int idealKilo;
            if (user.Gender == Gender.Male) idealKilo = (int)(50 + (2.3) * ((user.Height - 152.4) / 2.54));
            else idealKilo = (int)(45.5 + (2.3) * ((user.Height - 152.4) / 2.54));
            lblIdealKilo.Text = idealKilo.ToString();

            int alınasıGerekenKalori;
            if (user.Gender == Gender.Male) alınasıGerekenKalori = Convert.ToInt32(user.Weight * 24);
            else alınasıGerekenKalori = Convert.ToInt32(0.9 * user.Weight * 24);

        }

        private void lblKahvaltiEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MealAdd("Kahvaltı");
        }

        private void lblOgleEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MealAdd("Öğle");
        }

        private void lblAperatifEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MealAdd("Aperatif");
        }

        private void lblAksamEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MealAdd("Akşam");
        }

        private void lblEgzersizEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblSuEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(nudSuLitresi.Value > 0)
            {
                Water water = waterService.GetWaterByDateAndUserName(dtpTarih.Value.Date, user.UserID);
                if(water !=null)
                {
                    water.Quantity += (double)nudSuLitresi.Value;
                    if (waterService.UpdateWater(water))
                        MessageBox.Show("Su eklendi");
                    lblSu.Text = water.Quantity.ToString();
                }
                else
                {
                    water = new Water();
                    water.Quantity = (double)nudSuLitresi.Value;
                    water.WaterDate = dtpTarih.Value.Date;
                    water.User = user;
                    if (waterService.AddWater(water))
                        MessageBox.Show("İlk suyunuzu içtiniz afiyet olsun :)");

                    lblSu.Text = water.Quantity.ToString();
                }
            }
        }
        private void MealAdd(string mealName)
        {
            this.Hide();
            mealService = new MealService();
            Meal meal = mealService.GetMealByUserIDandMealCategoryName(user.UserID, mealName, dtpTarih.Value.Date);
            MealCategory mealCategory = mealcategoryService.GetMealCategoryByName(mealName);
            FormMeal formMeal = new FormMeal(meal, user, dtpTarih.Value.Date, mealCategory);
            formMeal.ShowDialog();
            this.Show();
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            Water water = waterService.GetWaterByDateAndUserName(dtpTarih.Value.Date, user.UserID);
            if (water != null)
            {
                lblSu.Text = water.Quantity.ToString();
            }
            else
                lblSu.Text = "0";
        }
    }
}
