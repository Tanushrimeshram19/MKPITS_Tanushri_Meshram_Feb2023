using Dropdownteatype.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Dropdownteatype.Controllers
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
        public ActionResult Index(UserModel model)
        {
            var selectedValue = model.SelectTeaType;
            ViewBag.TeaType = selectedValue.ToString();
            return View();

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
           IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
}
