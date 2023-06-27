using Microsoft.AspNetCore.Mvc;
using mvccustomer.Models;
using System.Diagnostics;
using System.Security.Principal;

namespace mvccustomer.Controllers
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
        public IActionResult Index(Customer a)
        {
            ViewBag.name = a.Name;
            ViewBag.amt = a.Amount;
            ViewBag.type = a.Acttype;
            int balance = 1000;

            if (a.Acttype == "Deposite")
            {
                a.result = balance + a.Amount;
                ViewBag.res = a.result;
            }
            if (a.Acttype == "Withdraw")
            {
                a.result = balance - a.Amount;
                ViewBag.res = a.result;
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