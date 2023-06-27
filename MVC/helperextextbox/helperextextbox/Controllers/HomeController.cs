using helperextextbox.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace helperextextbox.Controllers
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
        [HttpPost]
        public ActionResult Index(UserModel u)
        {
            if (u.Tea == true)
                ViewBag.Tea = "you selected Tea";
            if (u.Loundry == true)
                ViewBag.Loundry = "you selected Loundry";
            if (u.Breakfast == true)
                ViewBag.Breakfast = "you selected breakfast";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}