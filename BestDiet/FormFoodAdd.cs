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
    public partial class FormFoodAdd : Form
    {
        FoodService foodService;
        FoodCategoryService foodCategoryService;        
        public FormFoodAdd()
        {
            InitializeComponent();
            foodService = new FoodService();
            foodCategoryService = new FoodCategoryService();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                Food food = new Food();
                food.FoodName = txtYemekAdi.Text;
                food.Calori = Convert.ToInt32(nudKalori.Value);
                food.FoodCategoryID = Convert.ToInt32(cmbKategoriler.SelectedValue);
                food.ImagePath = txtResimYolu.Text;
                if (foodService.Insert(food)) MessageBox.Show("Yeni yemek eklendi");                
                else throw new Exception("Yemek ekleme esnasında bir hata oluştu :(");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormFoodAdd_Load(object sender, EventArgs e)
        {
            List<FoodCategory> foodCategories = foodCategoryService.GetFoodCategories();
            cmbKategoriler.DataSource = foodCategories;
            cmbKategoriler.ValueMember = "FoodCategoryID"; 
            cmbKategoriler.DisplayMember = "CategoryName"; 
        }
    }
}
