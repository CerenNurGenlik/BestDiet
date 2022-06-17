﻿using BusinessLogicLayer.Services;
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
    public partial class FormMeal : Form
    {
        Meal meal;
        User user;
        MealCategory mealCategory;
        DateTime dateTime;
        MealService mealService;
        MealDetail mealDetail;
        MealDetailService mealDetailService;
        FoodService foodService;
        List<Food> foodList;
        List<MealDetail> mealDetails;



        public FormMeal(Meal _meal, User _user, DateTime _dateTime, MealCategory _mealCategory)
        {
            InitializeComponent();
            meal = _meal;
            user = _user;
            dateTime = _dateTime;
            mealCategory = _mealCategory;
            foodService = new FoodService();
            mealDetailService = new MealDetailService();
            mealService = new MealService();
        }

        private void FormMeal_Load(object sender, EventArgs e)
        {
            Helper.ClearControls(Controls);
            foodList = foodService.GetFoods();

            if (meal != null)
            {
                mealDetails = mealDetailService.GetFoodsByMeal(meal.UserID, meal.MealCategoryID, meal.MealTime);
                EklenenYiyecekleriListele();
                lblOgunAdi.Text = meal.MealCategory.MealCategoryName;
                pbYemekResmi.Image = null;
            }

            YiyecekleriListele();

        }
        void YiyecekleriListele()
        {
            lvYiyecekler.Items.Clear();
            ListViewItem lvi;
            foreach (Food item in foodList)
            {
                lvi = new ListViewItem();
                lvi.Text = item.FoodName;
                lvi.SubItems.Add(item.FoodCategory.CategoryName);
                lvi.SubItems.Add(item.Calori.ToString());
                lvi.Tag = item.FoodID;
                lvYiyecekler.Items.Add(lvi);
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lvYiyecekler.SelectedItems.Count <= 0) return;
            else
            {
                if (meal == null)
                {
                    meal = new Meal();
                    meal.MealTime = dateTime;
                    meal.User = user;
                    meal.UserID = user.UserID;
                    meal.MealCategory = mealCategory;
                    meal.MealCategoryID = mealCategory.MealCategoryID;
                    mealService.Insert(meal);

                }
                int foodID = (int)lvYiyecekler.SelectedItems[0].Tag;
                Food food = foodService.GetByFoodID(foodID);

                try
                {
                    mealDetail = new MealDetail();
                    mealDetail.Food = food;
                    mealDetail.Meal = meal;
                    mealDetail.Quantity = Convert.ToInt32(nudUrunSayisi.Value);
                    mealDetail.Portion = Convert.ToInt32(nudPorsiyon.Value);
                    mealDetail.Calori = food.Calori;



                    if (mealDetailService.Insert(mealDetail))
                    {

                        MessageBox.Show("Yiyecekler eklendi.");

                    }
                    else throw new Exception("Ekleme esnasında bir hata oluştu..");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            EklenenYiyecekleriListele();
        }

        void EklenenYiyecekleriListele()
        {
            lvEklenenYiyecekler.Items.Clear();
            ListViewItem lvi;
            foreach (MealDetail item in mealDetails)
            {
                lvi = new ListViewItem();
                lvi.Text = item.Food.FoodName;
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(item.Portion.ToString());
                lvi.SubItems.Add(item.Calori.ToString());
                lvi.Tag = item.MealDetailID;
                lvEklenenYiyecekler.Items.Add(lvi);
            }
        }



        private void txtYiyecekAra_TextChanged(object sender, EventArgs e)
        {
            lvYiyecekler.Items.Clear();
            List<Food> foodListByText = new List<Food>();
            foodListByText = foodService.GetFoodsByText(txtYiyecekAra.Text);
            ListViewItem lvi;

            foreach (Food item in foodListByText)
            {
                lvi = new ListViewItem();
                lvi.Text = item.FoodName;
                lvi.SubItems.Add(item.FoodCategory.CategoryName);
                lvi.SubItems.Add(item.Calori.ToString());
                lvi.Tag = item.FoodID;
                lvYiyecekler.Items.Add(lvi);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lvEklenenYiyecekler.SelectedItems.Count <= 0) return;
            else
            {
                int mealDetailID = (int)lvEklenenYiyecekler.SelectedItems[0].Tag;
                MealDetail mealDetail = mealDetailService.GetMealDetailById(mealDetailID);
                if (mealDetail != null)
                {
                    mealDetail.Quantity = Convert.ToInt32(nudUrunSayisi.Value);
                    mealDetail.Portion = nudPorsiyon.Value;
                    mealDetail.Meal.MealTime = dtpOgunTarihi.Value;
                    bool check = mealDetailService.Update(mealDetail);

                    MessageBox.Show(check ? "Güncelleme başarılı !" : "Güncellenemedi !");
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvEklenenYiyecekler.SelectedItems.Count <= 0) return;
            else
            {
                int mealDetailID = (int)lvEklenenYiyecekler.SelectedItems[0].Tag;
                bool check = mealDetailService.Delete(mealDetailID);
                MessageBox.Show(check ? "Eklenen ürün silindi !" : "Silme işlemi başarısız !");
            }
        }

        private void lvEklenenYiyecekler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvEklenenYiyecekler.SelectedItems.Count <= 0) return;
            else
            {
                int mealDetailID = (int)lvEklenenYiyecekler.SelectedItems[0].Tag;
                MealDetail mealDetail = mealDetailService.GetMealDetailById(mealDetailID);

                if (mealDetail != null)
                {
                    dtpOgunTarihi.Value = mealDetail.Meal.MealTime;
                    nudPorsiyon.Value = mealDetail.Portion;
                    nudUrunSayisi.Value = mealDetail.Quantity;
                }
                else throw new Exception("Listeden eklenen ürünü seçiniz.");
            }
        }

        private void lvYiyecekler_MouseClick(object sender, MouseEventArgs e)
        {
            //BURAYI KONTROL ET EMİN DEĞİLİM (İMAGE DOSYA YOLU OLARAK TUTULUYOR ÇÜNKÜ !!!)

            if (lvYiyecekler.SelectedItems.Count <= 0) return;
            else
            {
                int foodID = (int)lvYiyecekler.SelectedItems[0].Tag;
                Food food = foodService.GetByFoodID(foodID);

                if (food.ImagePath != null)
                {
                    pbYemekResmi.Text = food.ImagePath;
                }
                else
                {
                    pbYemekResmi.Image = null;
                }

            }
        }

        private void btnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            FormFoodAdd formFoodAdd = new FormFoodAdd();
            formFoodAdd.ShowDialog();
        }
    }
}
