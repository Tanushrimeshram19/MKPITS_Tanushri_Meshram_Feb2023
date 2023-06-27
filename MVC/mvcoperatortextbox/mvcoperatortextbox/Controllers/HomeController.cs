using Microsoft.AspNetCore.Mvc;
using mvcoperatortextbox.Models;
//using mvcoperatortextbox.Views.UserModel;
using System.Diagnostics;

namespace mvcoperatortextbox.Controllers
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
        public ActionResult Index(UserModel u)
        {
            ViewBag.number1 = u.number1;
            ViewBag.number2 = u.number2;
            if (u.add == true)
            {
                u.result1 = u.number1 + u.number2;
                ViewBag.result1 = u.result1;
            }
            if (u.substract == true)
            {
                u.result2 = u.number1 - u.number2;
                ViewBag.result2 = u.result2;
            }
            if (u.multiply == true)
            {
                u.result3 = u.number1 * u.number2;
                ViewBag.result3 = u.result3;
            }

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