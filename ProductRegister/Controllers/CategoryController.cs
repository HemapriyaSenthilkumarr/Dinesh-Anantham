using Microsoft.AspNetCore.Mvc;
using ProductRegister.Data;
using ProductRegister.Models;

namespace ProductRegister.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<CategoryModel> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
