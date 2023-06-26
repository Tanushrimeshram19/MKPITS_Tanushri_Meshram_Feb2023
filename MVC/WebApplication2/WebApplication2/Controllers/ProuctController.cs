using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ProuctController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
