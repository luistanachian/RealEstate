using Microsoft.AspNetCore.Mvc;

namespace RealEstate.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
