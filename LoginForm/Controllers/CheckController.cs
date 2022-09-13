using LoginForm.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LoginForm.Controllers
{
    public class CheckController : Controller
    {
        public IActionResult Index()
        {
            var model = TempData.Get<UsersModel>("model");
            if (model is null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View("Check", model);
        }
    }
}
