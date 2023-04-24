using Microsoft.AspNetCore.Mvc;
using ProductRegister.Data;
using ProductRegister.Models;
using System.Diagnostics;

namespace ProductRegister.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Category()
        {
            IEnumerable<CategoryModel> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CategoryModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Category");
            }
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}