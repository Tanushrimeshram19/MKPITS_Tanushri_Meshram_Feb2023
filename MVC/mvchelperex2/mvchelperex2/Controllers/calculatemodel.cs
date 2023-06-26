using Microsoft.AspNetCore.Mvc;
using mvchelperex2.Models;

namespace mvchelperex2.Controllers
{
    public class calculatemodel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(calculatemodel cm)
        {
            int n1 = cm.num1;
            int n2 = cm.num2;
            int res = n1 + n2;
            ViewBag.result = res;
            return View();
        }
    }

}
}
