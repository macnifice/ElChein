using AspNetCore;
using ElChein.Model;
using Microsoft.AspNetCore.Mvc;

namespace ElChein.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlayera _playera;

        public HomeController(IPlayera playera)
        {
            _playera = playera;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
