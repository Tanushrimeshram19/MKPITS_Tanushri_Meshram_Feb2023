using helpercheckbox.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace helpercheckbox.Controllers
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
        public ActionResult Index(usermodel u)
        {
            if (u.tea == true)
                ViewBag.Tea = "you selected Tea";
            if (u.loundary == true)
                ViewBag.Loundry = "you selected Loundry";
            if (u.breakfast == true)
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