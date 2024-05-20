using Microsoft.AspNetCore.Mvc;
using website.Models;

namespace website.Controllers
{
    public class ProductsController : Controller
    {
        private readonly MyDBContext _context;
        public ProductsController(MyDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult JsonTest()
        {
            return View();
        }
    }
}
