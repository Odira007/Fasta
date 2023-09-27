using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastaApp.Entities;
using FastaApp.Persistence;
using FastaApp.Helpers;
using System.IO;
using FastaApp.Persistence.Interfaces;

namespace FastaApp.Core.Authentication
{
    public class Auth
    {
        private readonly IUserRepository _userRepository;
        public Auth(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public static User currentUser { get; set; }
        public static bool IsSignedIn { get; set; }
        public bool IsAdmin { get; set; }

        public async Task<bool> Login(string email, string password)
        {
            var users = await _userRepository.GetAllUsersAsync();
            var user = users.FirstOrDefault(x => x.Email == email && x.Password == password);
            var admins = users.Where(x => x.Role == "Admin" || x.Role == "Manager");

            if (user == null) return false;
            else
            {
                foreach (User admin in admins)
                {
                    if (user == admin) IsAdmin = true;
                    else
                    {
                        IsAdmin = false;
                    }
                }
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
