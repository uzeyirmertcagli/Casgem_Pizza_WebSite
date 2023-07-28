using Microsoft.AspNetCore.Mvc;
using Pizzapan.DataAccessLayer.Concrete;
using Pizzapan.EntityLayer.Concrete;
using System;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly Context _context;

        public ContactUsController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SendMessage p)
        {
            if (ModelState.IsValid)
            {
                p.Date = DateTime.Now;
                _context.SendMessages.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}