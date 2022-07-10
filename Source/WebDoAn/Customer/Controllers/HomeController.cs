using Customer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Customer.Repository;

namespace Customer.Controllers
{
    public class HomeController : Controller
    {
        WebsiteBanDoAnContext ctx = new WebsiteBanDoAnContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<MonAn> ma = ctx.MonAns.Include(x => x.MaLoaiNavigation).ToList();
            return View(ma);
        }

        public IActionResult About()
        {
            ViewBag.Title = "Abous";
            return View();
        }
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact";
            Contact contact = new Contact();
            return View(contact);
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                // check email
                Contact c = ctx.Contacts.Where(x => x.Email == contact.Email).SingleOrDefault();
                if (c != null)
                {
                    ModelState.AddModelError(string.Empty, "Email da ton tai!!");
                    return View(contact);
                }
                else
                {
                    ctx.Contacts.Add(contact);
                    ctx.SaveChanges();
                    return RedirectToAction("contact");
                }
            }
            else
            {
                return View(contact);
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
