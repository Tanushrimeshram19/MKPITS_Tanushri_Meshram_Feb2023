using helperradiobutton.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace helperradiobutton.Controllers
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
            ViewBag.number1 = u.num1;
            ViewBag.number2 = u.num2;
            string b = u.caltype.ToString();
            int result = 0;

            if (b == "add")
            {
                result = u.num1 + u.num2;

            }
            else if (b == "sub")
            {
                result = u.num1 - u.num2;

            }
            else if (b == "mul")
            {
                result = u.num1 * u.num2;

            }
            ViewBag.res = result;

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