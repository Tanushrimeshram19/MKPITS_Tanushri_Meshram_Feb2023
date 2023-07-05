using Connectioninsert.Models;
using Microsoft.AspNetCore.Mvc;

namespace Connectioninsert.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
   

       
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ItemModel ilist)
        {
            if (ModelState.IsValid)
            {
                Itemdbhandler db = new Itemdbhandler();
                if (db.InsertItem(ilist))
                {
                    ViewBag.message = "item saved successfully";
                    ModelState.Clear();
                }

            }
            return View();
        }
    }
}

