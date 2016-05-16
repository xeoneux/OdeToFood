using Microsoft.AspNet.Mvc;

namespace OdeToFood.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }
    }
}