using ElChein.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;

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
            var viewModel = new ClothingViewModel
            {
                Shirts = await _elCheinContext.Shirts.ToListAsync(),
                Pants = await _elCheinContext.Pants.ToListAsync(),
            };
            return View(viewModel);
        }
       
          
        
    }
}
