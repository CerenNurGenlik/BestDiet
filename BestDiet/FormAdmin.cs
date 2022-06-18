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
    public partial class FormAdmin : Form
    {
        UserService userService;
        FoodService foodService;
        SportService sportService;
        public FormAdmin()
        {
            InitializeComponent();
            userService = new UserService();
            foodService = new FoodService();
            sportService = new SportService();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            FillFoods();
            FillSports();
            FillUsers();
        }
        private void FillFoods()
        {
            lvYemek.Items.Clear();
            List<Food> foodList = foodService.GetFoodsAll();

            foreach(Food food in foodList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = food.FoodName;
                lvi.SubItems.Add(food.FoodCategory.CategoryName);
                lvi.SubItems.Add(food.Calori.ToString());
                lvi.SubItems.Add(food.IsActive ? "Akitf" : "Pasif");
                lvi.Tag = food.FoodID;
                lvYemek.Items.Add(lvi);
            }
        }
        private void FillSports() 
        {
            lvAktivite.Items.Clear();
            List<Sport> sportList = sportService.GetSports();

            foreach (Sport sport in sportList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text=sport.SportName;
                lvi.SubItems.Add(sport.BurningCalori.ToString());
                lvi.SubItems.Add(sport.IsActive ? "Aktif" : "Pasif");
                lvi.Tag = sport.SportID;
                lvAktivite.Items.Add(lvi);
            }
        }
        private void FillUsers()
        {
            lvKullanici.Items.Clear();
            List<User> userList = userService.GetUsers();

            foreach (User user in userList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = user.FirstName;
                lvi.SubItems.Add(user.LastName);
                lvi.SubItems.Add(user.UserID);
                lvi.SubItems.Add(userService.GetAge(user.UserID).ToString());
                lvi.SubItems.Add(user.Height.ToString());
                lvi.SubItems.Add(user.Weight.ToString());
                lvi.SubItems.Add(user.TargetWeight.ToString());
                lvi.SubItems.Add("Favori Yiyecek");
                lvi.SubItems.Add("Favori Aktivite");
                lvi.SubItems.Add(user.IsActive ? "Aktif" : "Pasif");
                lvi.Tag = user.UserID;
                lvKullanici.Items.Add(lvi);
            }
        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            FormFoodAdd formFood = new FormFoodAdd();
            formFood.ShowDialog();
            FillFoods();
        }

        private void btnYemekSil_Click(object sender, EventArgs e)
        {
            if (lvYemek.SelectedItems.Count != 1) return;

            DialogResult dr = MessageBox.Show("Silme işlemini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            if (foodService.DoPassiveByFoodID((int)lvYemek.SelectedItems[0].Tag)) ;
            MessageBox.Show("Yiyecek pasif hale getirildi");

            FillFoods();
        }

        private void btnYemekGüncelle_Click(object sender, EventArgs e)
        {
            if (lvYemek.SelectedItems.Count != 1) return;

            FormFoodAdd formFoodAdd = new FormFoodAdd((int)lvYemek.SelectedItems[0].Tag);
            formFoodAdd.ShowDialog();
            FillFoods();
        }

        private void txtYemekAra_TextChanged(object sender, EventArgs e)
        {
            lvYemek.Items.Clear();
            List<Food> foodListByText = new List<Food>();
            foodListByText = foodService.GetFoodsByText(txtYemekAra.Text);
            ListViewItem lvi;

            foreach (Food item in foodListByText)
            {
                lvi = new ListViewItem();
                lvi.Text = item.FoodName;
                lvi.SubItems.Add(item.FoodCategory.CategoryName);
                lvi.SubItems.Add(item.Calori.ToString());
                lvi.SubItems.Add(item.IsActive.ToString());
                lvi.Tag = item.FoodID;
                lvYemek.Items.Add(lvi);
            }
        }

        private void txtAktiviteAra_TextChanged(object sender, EventArgs e)
        {
            lvAktivite.Items.Clear();
            List<Sport> sports = new List<Sport>();
            sports = sportService.GetFoodsByText(txtAktiviteAra.Text);
            ListViewItem lvi;

            foreach (Sport item in sports)
            {
                lvi = new ListViewItem();
                lvi.Text = item.SportName;
                lvi.SubItems.Add(item.BurningCalori.ToString());
                lvi.SubItems.Add(item.IsActive.ToString());
                lvi.Tag = item.SportID;
                lvAktivite.Items.Add(lvi);
            }
        }
    }
}
