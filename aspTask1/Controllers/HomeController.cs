using aspTask1.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspTask1.Controllers
{
    public class HomeController : Controller
    {
        // getting the main index view models which keeps : "Drinks" , "FastFoods" and "HotMeals" as a DB :  
        public IndexViewModel IndexViewModel { get; set; } = new IndexViewModel();

        [HttpGet]
        public IActionResult Index()
        {
            return View(IndexViewModel);
        }

        [HttpGet]
        public IActionResult FastFoods()
        {
            return View(IndexViewModel.FastFoods);
        }

        [HttpGet]
        public IActionResult Drinks()
        {
            return View(IndexViewModel.Drinks);
        }

        [HttpGet]
        public IActionResult HotMeals() {
            return View(IndexViewModel.HotMeals);
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
