﻿using FormValidation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using validex1.Models;

namespace validex1.Controllers
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
        public ActionResult StudentDetails(StudentModel sm)
        {
            if (string.IsNullOrEmpty(sm.Name))
            {
                ModelState.AddModelError("Name", "Name Required");
            }
            if (sm.Age == 0 || sm.Age > 120)
            {
                ModelState.AddModelError("Age", "Please Enter Valid Age between 1-120");
            }

            if (ModelState.IsValid)
            {
                ViewBag.name = sm.Name;
                ViewBag.age = sm.Age;
                return View("Index");
            }
            else
            {
                ViewBag.name = "No Data";
                ViewBag.age = "No Data";
                return View("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}