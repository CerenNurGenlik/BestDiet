using Model.Entites;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Strategy
{
    public class BestDietStrategy : CreateDatabaseIfNotExists<BestDietDbContext>
    {
        protected override void Seed(BestDietDbContext context)
        {
            User user = new User()
            {
                UserID = "Admin",
                FirstName = "Admin",
                LastName = "Admin",
                IsActive = true,
                UserType = UserType.Admin
            };
            context.Users.Add(user);
            context.SaveChanges();

            List<Sport> sports = new List<Sport>();

            sports.Add(new Sport() { SportName = "Koşu", BurningCalori = 565 });
            sports.Add(new Sport() { SportName = "Yüzme", BurningCalori = 650 });
            sports.Add(new Sport() { SportName = "Yürüyüş", BurningCalori = 500 });
            sports.Add(new Sport() { SportName = "Bisiklet", BurningCalori = 600 });
            sports.Add(new Sport() { SportName = "Tenis", BurningCalori = 450 });
            sports.Add(new Sport() { SportName = "Futbol", BurningCalori = 588 });
            sports.Add(new Sport() { SportName = "Pilates", BurningCalori = 200 });
            sports.Add(new Sport() { SportName = "Basketbol", BurningCalori = 440 });
            sports.Add(new Sport() { SportName = "Voleybol", BurningCalori = 294 });
            sports.Add(new Sport() { SportName = "Golf", BurningCalori = 390 });
            sports.Add(new Sport() { SportName = "Ağırlık Çalışması", BurningCalori = 440 });

            context.Sports.AddRange(sports);

            List<FoodCategory> foodCategories = new List<FoodCategory>();

            foodCategories.Add(new FoodCategory() { CategoryName = "Beyaz Et" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Kırmızı Et" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Baklagil" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Salata" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Meyve" });
            foodCategories.Add(new FoodCategory() { CategoryName = "İçecek" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Kuruyemiş" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Temel Gıda" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Atıştırmalık" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Unlu Mamüller" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Süt Ürünleri" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Fast Food" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Tatlı & Tuzlu" });
            foodCategories.Add(new FoodCategory() { CategoryName = "Sebze" });
           

            context.FoodCategories.AddRange(foodCategories);

            List<Food> foods = new List<Food>();

            foods.Add(new Food() { FoodName = "Tavuk Sote", Calori =288, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Tavuk Kanat", Calori =252, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Tavuk Çorbası", Calori =132, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Tavuk Baget", Calori =238, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Tavuk Göğüs", Calori =120, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Tavuk Şiş", Calori =208, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Tavuk Döner", Calori =149, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Tavuk Ciğer", Calori =167, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Tavuk Izgara", Calori =274, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Tavuk Tantuni", Calori =415, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Hindi But(1 but 546g)", Calori =1136, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Hindi Göğüs(1/2 864g)", Calori =1166, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Hindi Kanat", Calori =221, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Ördek(634g)", Calori =337, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Balık Kızartma(200g)", Calori =585, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Balık Izgara", Calori =230, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Balık Buğlama", Calori =398, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Balık Çorbası", Calori =146, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Fırında Balık", Calori =334, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Balık Nuget", Calori =196, FoodCategoryID =1});
            foods.Add(new Food() { FoodName = "Ton Balık(80gr)", Calori =110, FoodCategoryID =1});            

            foods.Add(new Food() { FoodName = "Antrikot", Calori =303, FoodCategoryID =2});
            foods.Add(new Food() { FoodName = "İskender", Calori =476, FoodCategoryID =2});
            foods.Add(new Food() { FoodName = "Bonfile", Calori =276, FoodCategoryID =2});
            foods.Add(new Food() { FoodName = "Dana Kıyma", Calori =172, FoodCategoryID =2});
            foods.Add(new Food() { FoodName = "Kuzu Pirzola", Calori =276, FoodCategoryID =2});
            foods.Add(new Food() { FoodName = "Sığır Eti", Calori =248, FoodCategoryID =2});
            foods.Add(new Food() { FoodName = "Dana Kavurma", Calori =360, FoodCategoryID =2});
            foods.Add(new Food() { FoodName = "Sığır Eti", Calori =248, FoodCategoryID =2});
            foods.Add(new Food() { FoodName = "Et Şiş", Calori =324, FoodCategoryID =2});
            foods.Add(new Food() { FoodName = "Ciğer Şiş", Calori =287, FoodCategoryID =2});
            foods.Add(new Food() { FoodName = "Haşlama Çorbası", Calori =159, FoodCategoryID =2});
            foods.Add(new Food() { FoodName = "Etli Biber Dolması", Calori =95, FoodCategoryID =2});
            foods.Add(new Food() { FoodName = "Et Döner", Calori =301, FoodCategoryID =2});

            foods.Add(new Food() { FoodName = "Bamya", Calori =33, FoodCategoryID =3});
            foods.Add(new Food() { FoodName = "Bezelye", Calori =42, FoodCategoryID =3});
            foods.Add(new Food() { FoodName = "Barbunya Fasulye", Calori =347, FoodCategoryID =3});
            foods.Add(new Food() { FoodName = "Kuru Fasulye", Calori =336, FoodCategoryID =3});
            foods.Add(new Food() { FoodName = "Mercimek", Calori =353, FoodCategoryID =3});
            foods.Add(new Food() { FoodName = "Yeşil Mercimek", Calori =257, FoodCategoryID =3});
            foods.Add(new Food() { FoodName = "Nohut", Calori =364, FoodCategoryID =3});

            foods.Add(new Food() { FoodName = "Çoban Salata", Calori =115, FoodCategoryID =4});
            foods.Add(new Food() { FoodName = "Mevsim Salata", Calori =59, FoodCategoryID =4});
            foods.Add(new Food() { FoodName = "Sezar Salata", Calori =466, FoodCategoryID =4});
            foods.Add(new Food() { FoodName = "Tavuklu Salata", Calori =130, FoodCategoryID =4});
            foods.Add(new Food() { FoodName = "Ton Balıklı Salata", Calori =327, FoodCategoryID =4});

            foods.Add(new Food() { FoodName = "Ahududu", Calori =64, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Ananas", Calori =50, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Armut", Calori =57, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Avokado", Calori =160, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Ayva", Calori =57, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Böğürtlen", Calori =43, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Elma", Calori =52, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Erik", Calori =46, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Üzüm", Calori =56, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "İncir", Calori =74, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Muz", Calori =122, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Karpuz", Calori =30, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Kayısı", Calori =48, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Kiraz", Calori =50, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Kivi", Calori =61, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Limon", Calori =29, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Mandalina", Calori =53, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Nar", Calori =83, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Portakal", Calori =47, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Şeftali", Calori =39, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Çilek", Calori =32, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Şeftali", Calori =39, FoodCategoryID =5});
            foods.Add(new Food() { FoodName = "Kavun", Calori =34, FoodCategoryID =5});

            foods.Add(new Food() { FoodName = "Biber", Calori =20, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Brokoli", Calori =207, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Lahana", Calori =8, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Domates", Calori =20, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Ispanak", Calori =78, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Kabak", Calori =51, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Kara Lahana", Calori =12, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Karnıbahar", Calori =3, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Kırmızı Biber", Calori =12, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Mantar", Calori =22, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Mısır", Calori =365, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Patates", Calori =164, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Patlıcan", Calori =115, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Pırasa", Calori =61, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Roka", Calori =1, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Salatalık", Calori =33, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Sarımsak", Calori =4, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Soğan", Calori =34, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Turp", Calori =34, FoodCategoryID =14});
            foods.Add(new Food() { FoodName = "Havuç", Calori =25, FoodCategoryID =14});

            foods.Add(new Food() { FoodName = "Boza", Calori =370, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Coca Cola", Calori =139, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Gazoz", Calori =105, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Ice Tea", Calori =135, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Kahve", Calori =2, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Cola Zero", Calori =1, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Latte Macchiato", Calori =57, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Limonata", Calori =42, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Milkshake", Calori =329, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Süt", Calori =61, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Sıcak Çikolata", Calori =89, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Türk Kahvesi", Calori =2, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Çay", Calori =2, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Bitki Çayı", Calori =2, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Fanta", Calori =140, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Meyveli Soda", Calori =94, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Portakal Suyu", Calori =90, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Ayran", Calori =76, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Espresso", Calori =151, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Frappuccino ", Calori =258, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "White Chocolate Mocha", Calori =257, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Viski", Calori =125, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Rakı", Calori =131, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Bira", Calori =138, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Şarap", Calori =111, FoodCategoryID =6});
            foods.Add(new Food() { FoodName = "Votka", Calori =116, FoodCategoryID =6});

            foods.Add(new Food() { FoodName = "Fındık", Calori =154, FoodCategoryID =7});
            foods.Add(new Food() { FoodName = "Badem", Calori =150, FoodCategoryID =7});
            foods.Add(new Food() { FoodName = "Ceviz", Calori =164, FoodCategoryID =7});
            foods.Add(new Food() { FoodName = "Lebleli", Calori =24, FoodCategoryID =7});
            foods.Add(new Food() { FoodName = "Antep Fıstığı", Calori =101, FoodCategoryID =7});
            foods.Add(new Food() { FoodName = "Kaju", Calori =138, FoodCategoryID =7});
            foods.Add(new Food() { FoodName = "Fıstık", Calori =170, FoodCategoryID =7});
            foods.Add(new Food() { FoodName = "Kabak Çekirdeği", Calori =56, FoodCategoryID =7});

            foods.Add(new Food() { FoodName = "Makarna", Calori =141, FoodCategoryID =8});
            foods.Add(new Food() { FoodName = "Pirinç Pilavı", Calori = 258, FoodCategoryID = 8 });
            foods.Add(new Food() { FoodName = "Bulgur Pilavı", Calori = 149, FoodCategoryID = 8 });  
            
            foods.Add(new Food() { FoodName = "Cips", Calori = 124, FoodCategoryID = 9 });      
            foods.Add(new Food() { FoodName = "Patetes Kızartması", Calori = 250, FoodCategoryID = 9 }); 
            
            foods.Add(new Food() { FoodName = "1 dilim Ekmek", Calori = 64, FoodCategoryID = 10 });   
            
            foods.Add(new Food() { FoodName = "Beyaz Peynir", Calori = 93, FoodCategoryID = 11 });      
            foods.Add(new Food() { FoodName = "Kaşar Peyniri", Calori = 71, FoodCategoryID = 11 });      
            foods.Add(new Food() { FoodName = "Yoğurt", Calori = 122, FoodCategoryID = 11 });        

            foods.Add(new Food() { FoodName = "Tavuk Burger", Calori = 274, FoodCategoryID = 12 });
            foods.Add(new Food() { FoodName = "Hamburger", Calori = 386, FoodCategoryID = 12 });
            foods.Add(new Food() { FoodName = "Cheeseburger", Calori = 410, FoodCategoryID = 12 });

            foods.Add(new Food() { FoodName = "Sütlaç", Calori = 250, FoodCategoryID = 13 });
            foods.Add(new Food() { FoodName = "Kazandibi", Calori = 200, FoodCategoryID = 13 });
            foods.Add(new Food() { FoodName = "Baklava", Calori = 165, FoodCategoryID = 13 });
            foods.Add(new Food() { FoodName = "Künefe", Calori = 420, FoodCategoryID = 13 });

            context.Foods.AddRange(foods);
        }
    }
}
