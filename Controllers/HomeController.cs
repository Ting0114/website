using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using website.Models;

namespace website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDBContext _context;

        public HomeController(ILogger<HomeController> logger, MyDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult First()
        {
            return View();
        }
        public IActionResult Address()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult JSONTest()
        {
            return View();
        }


        public IActionResult Index()

        {

            var categories = from r in _context.Categories select r;

            return View(categories);

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