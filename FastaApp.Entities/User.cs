﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FastaApp.Entities
{
    public partial class User
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required(ErrorMessage = "First name is required.")]
        [DataType(DataType.Text)]
        [StringLength(25, ErrorMessage = "First name must be between 2 to 50 characters", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [DataType(DataType.Text)]
        [StringLength(25, ErrorMessage = "First name must be between 2 to 50 characters", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "User name is required.")]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "User name must be between 2 to 50 characters", MinimumLength = 2)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?",
            ErrorMessage = "Email address is in the wrong format")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[\W_]).{6,20}$",
            ErrorMessage = "Your password should be 6 to 20 characters long, should alphanumeric characters, at least one uppercase letter, and a special character")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public string ProfileColor { get; set; } = "";
        public DateTime DateRegistered { get; set; } = DateTime.Now;
        public string Role { get; set; } = "User";
    }
}
