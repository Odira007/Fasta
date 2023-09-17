using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastaApp.Entities;
using FastaApp.Core.Interfaces;
using FastaApp.Core.Authentication;
using FastaApp.Helpers;

namespace FastaApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly RandomColor _randomColor;
        public UserController(IUserService userService, RandomColor randomColor)
        {
            _userService = userService;
            _randomColor = randomColor;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                user.ProfileColor = _randomColor.GetRandomColor();
                _userService.CreateUser(user);
                Auth.IsSignedIn = true;
                Auth.currentUser = user;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("PropertyName", "Custom error message");
                return View(user);
            }
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (Auth.Login(user.Email, user.Password))
            {
                user.ProfileColor = _randomColor.GetRandomColor();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("UnknownUser", "Email or Password was not found.");
                return View(user);
            }
        }

        public IActionResult Logout()
        {
            Auth.Logout();
            return RedirectToAction("Login", "User");
        }
    }
}
