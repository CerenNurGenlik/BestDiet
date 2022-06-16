using DataAccessLayer.Repositories;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class UserService
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }
        public User CheckLogin(string userName, string password)
        {
            return userRepository.CheckLogin(userName, password);
        }
        public User GetUserByUserName(string userName)
        {
            return userRepository.GetUserByUserName(userName);
        }
        public void InsertUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName))
                throw new Exception("İsim yada Soyisim boş olamaz!");
            else if (user.BirthDate > DateTime.Now.AddYears(-6))
                throw new Exception("Kullnıcı 6 yaşından küçük olamaz!");
            else if (user.Height < 100 || user.Height > 240)
                throw new Exception("Kullanıcı boyu 100cm den az, 240cm den fazla olamaz!");
            else if (user.Weight < 40 || user.Weight > 400)
                throw new Exception("Kullanıcı kilosu 40kg den küçük, 400kg den fazla olamaz!");
            else if(user.TargetWeight > user.Weight || user.TargetWeight<40)
                throw new Exception("Kullanıcı hedef kilosu şu anki kilosundan büyük olamaz ve 40kg den az olamaz");
        }
    }
}
