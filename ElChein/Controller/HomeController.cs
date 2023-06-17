using ElChein.Model;
using Microsoft.AspNetCore.Mvc;

namespace ElChein.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShirt _shirt;

        public HomeController(IShirt Shirt)
        {
            _shirt = Shirt;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
