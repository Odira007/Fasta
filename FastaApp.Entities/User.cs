using System;

namespace FastaApp.Entities
{
    public class User
    {
        //public User(string firstName, string lastName, string userName, string email, string password, string phoneNumber, string confirmPassword)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    UserName = userName;
        //    Email = email;
        //    Password = password;
        //    PhoneNumber = phoneNumber;
        //    ConfirmPassword = confirmPassword;
        //}
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
