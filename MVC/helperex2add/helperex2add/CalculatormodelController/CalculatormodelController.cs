using helperex2add.Models;
using Microsoft.AspNetCore.Mvc;

namespace helperex2add.Controllers
{
    public class CalculatormodelController : Controller
    {
        public IActionResult Index(Calculatormodel cm)
        {
            int n1 = cm.num1;
            int n2 = cm.num2;
            int res = n1 + n2;
            ViewBag.result = res;
            return View();

        }
    }
}
