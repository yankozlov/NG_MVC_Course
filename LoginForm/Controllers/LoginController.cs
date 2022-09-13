﻿using LoginForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginForm.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }
        public IActionResult Auth(UsersModel model)
        {
            model.Login = this.Request.Form["login"];
            model.Password = this.Request.Form["password"];
            model.IsLogged = false;
            foreach (var record in UsersData.Data)
            {
                if (record.Login == model.Login && record.Password == model.Password)
                {
                    model.IsAdmin = record.IsAdmin;
                    model.IsLogged = true;
                }
            }
            TempData.Put<UsersModel>("model", model);
            return RedirectToAction("Index", "Check");
        }
    }
}