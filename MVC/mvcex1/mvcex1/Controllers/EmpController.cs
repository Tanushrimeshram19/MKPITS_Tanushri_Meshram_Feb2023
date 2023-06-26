using Microsoft.AspNetCore.Mvc;

namespace mvcex1.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
