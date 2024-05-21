﻿using Microsoft.AspNetCore.Mvc;
using website.Models;

namespace website.Controllers
{
    public class APiController : Controller
    {
        private readonly MyDBContext _context;
        public APiController(MyDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return Content("<h2>世界,您好!!</h2>","text/html",System.Text.Encoding.UTF8);
        }
        public IActionResult First()
        {
            return View();
        }
        public IActionResult Cities()
        {
            var cities = _context.Addresses.Select(a => a.City).Distinct();
            return Json(cities);
        }
        public IActionResult Avatar(int id = 3) 
        {
            Member? member = _context.Members.Find(id);
            if (member != null)
            {
                byte[] img = member.FileData;
                if(img != null)
                {
                    return File(img, "image/jpeg");
                }
            }

            return NotFound();
        }
    }
}
