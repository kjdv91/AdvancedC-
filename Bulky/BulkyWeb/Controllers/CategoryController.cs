using BulkyWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BulkyContext _db;

        public CategoryController(BulkyContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public  IActionResult Details()
        {
            var objCategory = _db.Categories.ToList();
            return View(objCategory);
        }
    }
}
