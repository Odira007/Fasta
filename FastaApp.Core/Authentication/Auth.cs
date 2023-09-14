using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastaApp.Entities;
using FastaApp.Persistence;

namespace FastaApp.Core.Authentication
{
    public static class Auth
    {
        public static User currentUser { get; set; }

        public static bool Login(string email, string password)
        {
            var user = DataStore.Users.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user == null) return false;
            else
            {
                currentUser = user;
                return true;
            }
        }
        public static void Logout()
        {
            currentUser = null;
        }
    }

}
