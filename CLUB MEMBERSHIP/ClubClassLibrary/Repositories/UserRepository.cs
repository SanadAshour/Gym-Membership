using ClubClassLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubClassLibrary.Models;


namespace ClubClassLibrary.Repositories
{
    public class UserRepository
    {
        private readonly AppDbContext ADC = new AppDbContext();

        public User CheckLogin(string email, string password)
        {
            var user = ADC.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            return user;
        }
    }
}
