using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Viewmodel.Models;

namespace Viewmodel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = "Welcome to my demo!";
            //ViewData["Teachers"] = GetTeachers();
            //ViewData["Students"] = GetStudents();
            //return View();
            Teacher teacher = new Teacher();
            Student student = new Student();
            ViewBag.Message = "Welcome to my demo!";
            dynamic mymodel = new ExpandoObject();
            mymodel.Teachers = teacher.GetTeachers();
            mymodel.Students = student.GetStudents();
            return View(mymodel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}