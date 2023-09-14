using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastaApp.Entities;
using FastaApp.Core.Interfaces;
using FastaApp.Core.Authentication;

namespace FastaApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
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
                _userService.CreateUser(user);
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
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.UnknownUserMessage = "Email or password was not found";
                return View(user);
            }
        }
    }
}
