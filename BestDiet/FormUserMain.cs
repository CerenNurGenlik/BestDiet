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
        Water water;
        MealService mealService;
        ExerciseService exerciseService;
        WaterService waterService;
        public FormUserMain(User _user)
        {
            InitializeComponent();
            user = _user;
        }
        
        private void FormUserMain_Load(object sender, EventArgs e)
        {
            Helper.ClearControls(Controls);
            lblKullaniciAdi.Text = user.FirstName + " " + user.LastName;
            lblKilo.Text = user.Weight.ToString();
            lblBoy.Text=user.Height.ToString();
            lblYas.Text = (DateTime.Now - user.BirthDate).ToString();

            double vki = user.Weight / (user.Height * user.Height);
            lblKitleIndeksi.Text= vki.ToString();

            int idealKilo;
            if (user.Gender==Gender.Male) idealKilo = (int)(50 + (2.3) * ((user.Height - 152.4) / 2.54));
            else idealKilo = (int)(45.5 + (2.3) * ((user.Height - 152.4) / 2.54));            
            lblIdealKilo.Text= idealKilo.ToString();

            int alınasıGerekenKalori;
            if (user.Gender == Gender.Male) alınasıGerekenKalori = Convert.ToInt32(user.Weight * 24);
            else alınasıGerekenKalori= Convert.ToInt32(0.9*user.Weight * 24);


        }

        private void lblKahvaltiEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            mealService = new MealService();
            Meal meal = mealService.GetMealByUserIDandMealCategoryName(user.UserID, "Sabah", dtpTarih.Value);
            FormMeal formMeal = new FormMeal(meal);
            formMeal.ShowDialog();            
        }

        private void lblOgleEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            mealService = new MealService();
            Meal meal = mealService.GetMealByUserIDandMealCategoryName(user.UserID, "Öğle", dtpTarih.Value);
            FormMeal formMeal = new FormMeal(meal);
            formMeal.ShowDialog();
        }

        private void lblAperatifEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            mealService = new MealService();
            Meal meal = mealService.GetMealByUserIDandMealCategoryName(user.UserID, "Aperatif", dtpTarih.Value);
            FormMeal formMeal = new FormMeal(meal);
            formMeal.ShowDialog();
        }

        private void lblAksamEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            mealService = new MealService();
            Meal meal = mealService.GetMealByUserIDandMealCategoryName(user.UserID, "Akşam", dtpTarih.Value);
            FormMeal formMeal = new FormMeal(meal);
            formMeal.ShowDialog();
        }

        private void lblEgzersizEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            exerciseService = new ExerciseService();
            Exercise exercise = exerciseService.GetExercise(user.UserID,dtpTarih.Value);
            FormActivity formActivity = new FormActivity(exercise);
            formActivity.ShowDialog();
        }

        private void lblSuEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
