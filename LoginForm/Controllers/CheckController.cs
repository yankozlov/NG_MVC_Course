using LoginForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginForm.Controllers
{
    public class CheckController : Controller
    {
        public IActionResult Index(UsersModel model)
        {
            if (model.Login == null || model.Password == null)
            {
                return RedirectToAction("Index", "Login");
            }
            model = UsersData.Auth(model);
            return View("Check", model);
        }
    }
}
