using Microsoft.AspNetCore.Mvc;

namespace mvcex1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
