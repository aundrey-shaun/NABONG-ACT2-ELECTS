using Microsoft.AspNetCore.Mvc;
using ShaunPortfolio.Models;

namespace ShaunPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View("~/Views/About/About.cshtml"); // Correct path
        }

        public IActionResult Portfolio()
        {
            return View("~/Views/Portfolio/Portfolio.cshtml"); // Correct path
        }

        public IActionResult Contact()
        {
            return View("~/Views/Contact/Contact.cshtml"); // Correct path
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Success = "Your message has been sent!";
            }
            return View("~/Views/Contact/Contact.cshtml", model); // Correct path for post request
        }
    }
}
