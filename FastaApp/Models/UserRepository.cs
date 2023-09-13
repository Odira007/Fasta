using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastaApp.Models
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser(User User)
        {
            var user = new User()
            {
                FirstName = User.FirstName,
                LastName = User.LastName,
                UserName = User.UserName,
                Email = User.Email,
                Password = User.Password,
                ConfirmPassword = User.ConfirmPassword,
                PhoneNumber = User.PhoneNumber
            };
        }
    }
}
