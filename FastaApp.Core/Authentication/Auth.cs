using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastaApp.Entities;
using FastaApp.Persistence;
using FastaApp.Helpers;
using System.IO;

namespace FastaApp.Core.Authentication
{
    public class Auth
    {
        public static User currentUser { get; set; }
        public static bool IsSignedIn { get; set; }

        public static bool Login(string email, string password)
        {
            var user = DataStore.Users.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user == null) return false;
            else
            {
                currentUser = user;
                IsSignedIn = true;
                return true;
            }
        }
        public static void Logout()
        {
            currentUser = null;
            IsSignedIn = false;
        }
    }

}
