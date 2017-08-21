using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using UserReg.Models;

namespace UserReg.Controllers
{
    public class UsersController: Controller
    {
        private UserContext _context;
        public UsersController(UserContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Register()
        {
            ViewBag.Errors = new List<string>();
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                PasswordHasher<Users> Hasher = new PasswordHasher<Users>();
                Users NewUser = new Users
                {
                    first_name = model.first_name,
                    last_name = model.last_name,
                    email = model.email,
                    username = model.username,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                NewUser.password = Hasher.HashPassword(NewUser, model.password);

                _context.Add(NewUser);
                _context.SaveChanges();
                //query database
                //hash password
                Users NewAccount = _context.Users.SingleOrDefault(user => user.email == model.email);
                HttpContext.Session.SetString("first_name", NewAccount.first_name);
                HttpContext.Session.SetInt32("id", NewAccount.id);


                return RedirectToAction("Account", "Transaction", new { UserId = NewAccount.id}); //change this line!
                //add new user to database!
            }
            System.Console.WriteLine("Not Valid!");
            ViewBag.Errors = new List<string>();
            return View("Register");
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(string Email, string PasswordToCheck)
        {
            Users loggedUser = _context.Users.SingleOrDefault(user => user.email == Email);
            System.Console.WriteLine(loggedUser);
            System.Console.WriteLine(loggedUser.email);
            if (loggedUser != null && PasswordToCheck != null)
            {
                var Hasher = new PasswordHasher<Users>();
                if (0 != Hasher.VerifyHashedPassword(loggedUser, loggedUser.password, PasswordToCheck))
                {
                    HttpContext.Session.SetString("first_name", loggedUser.first_name);
                    HttpContext.Session.SetInt32("id", loggedUser.id);
                    return RedirectToAction("Account", "Transaction", new { UserId = loggedUser.id});
                }
            }
            System.Console.WriteLine(loggedUser.password);
            System.Console.WriteLine(PasswordToCheck);

            ViewBag.Errors = new List<string>();
            return View("Register");
        }

        [HttpGet]
        [Route("UserLogin")]
        public IActionResult UserLogin()
        {
            ViewBag.Errors = new List<string>();
            return View("Login");
        }
    }
}