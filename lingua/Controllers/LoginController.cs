using Microsoft.AspNetCore.Mvc;

namespace lingua.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
