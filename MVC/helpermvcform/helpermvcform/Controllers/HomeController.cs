using helpermvcform.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace helpermvcform.Controllers
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
        [HttpPost]
        public IActionResult Index(SignUp s)
        {
            ViewBag.username = s.username;
            ViewBag.password = s.password;
            ViewBag.email=s.email;
            ViewBag.geneder = s.gender;
            ViewBag.subject1 = s.subject1;
            ViewBag.subject2 = s.subject2;
            ViewBag.subject3 = s.subject3;
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