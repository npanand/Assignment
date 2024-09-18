using assignmentProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace assignmentProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AdminLogin()
        {
            //viewbag - dynamic
            ViewBag.title = "AdminLogin1";
            return View();
        }
        public IActionResult Contact()
        {
            //viewdata - key /value
            ViewData["title"] = "Contact Pages";
            return View();
        }
        public IActionResult Address()
        {
            //tempdata - key /value
            TempData["title"] = "Address pages";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
