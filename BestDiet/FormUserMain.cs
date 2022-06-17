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
            this.Hide();
            mealService = new MealService();
            Meal meal = mealService.GetMealByUserIDandMealCategoryName(user.UserID, "Sabah", dtpTarih.Value);
            MealCategory mealCategory = mealcategoryService.GetMealCategoryByName("Sabah");
            FormMeal formMeal = new FormMeal(meal, user, dtpTarih.Value, mealCategory);
            formMeal.ShowDialog();
        }

        private void lblOgleEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblAperatifEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblAksamEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblEgzersizEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblSuEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
