using Microsoft.AspNetCore.Mvc;

namespace LoginForm.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }
    }
}
