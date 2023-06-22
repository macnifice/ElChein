using ElChein.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElChein.Controllers
{
    public class HomeController : Controller
    {
        private readonly ElCheinContext _elCheinContext;

        public HomeController(ElCheinContext elCheinContext)
        {
            _elCheinContext = elCheinContext;
        }


        public async Task<IActionResult> Index()
        {
            var Shirt = _elCheinContext.Shirts.ToList();
            return View(Shirt);
        }
    }
}
