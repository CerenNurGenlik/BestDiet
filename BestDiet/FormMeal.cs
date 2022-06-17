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
    public partial class FormMeal : Form
    {
        Meal meal;
        MealDetail mealDetail;
        MealDetailService mealDetailService;
        FoodService foodService;
        List<Food> foodList;
        List<MealDetail> mealDetails = new List<MealDetail>();


        public FormMeal(Meal _meal)
        {
            InitializeComponent();
            meal = _meal;
            foodService = new FoodService();            
        }

        private void FormMeal_Load(object sender, EventArgs e)
        {
            Helper.ClearControls(Controls);
            foodList = foodService.GetFoods();
            YiyecekleriListele();
            lblOgunAdi.Text = meal.MealCategory.MealCategoryName;
        }
        void YiyecekleriListele()
        {
            lvYiyecekler.Items.Clear();
            ListViewItem lvi;
            foreach (Food item in foodList )
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
            int foodID = (int)lvYiyecekler.SelectedItems[0].Tag;
            Food food=foodService.GetByFoodID(foodID);
            
            mealDetail=new MealDetail();
            mealDetail.FoodID = foodID;
            mealDetail.MealID = meal.MealID;
            mealDetail.Quantity = Convert.ToInt32(nudUrunSayisi.Value); 
            mealDetail.Portion = Convert.ToInt32(nudPorsiyon.Value);
            mealDetail.Calori = food.Calori;
            mealDetail.Meal.MealTime = dtpOgunTarihi.Value;
            mealDetails.Add(mealDetail);
            EklenenYiyecekleriListele();
        }
        void EklenenYiyecekleriListele()
        {
            lvEklenenYiyecekler.Items.Clear();
            ListViewItem lvi;
            foreach (MealDetail item in mealDetails)
            {
                lvi = new ListViewItem();
                lvi.Text = mealDetail.Food.FoodName;
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(item.Portion.ToString());
                lvi.SubItems.Add(item.Calori.ToString());
                lvi.Tag = item.MealDetailID;
                lvEklenenYiyecekler.Items.Add(lvi);
            }
        }
    }
}
