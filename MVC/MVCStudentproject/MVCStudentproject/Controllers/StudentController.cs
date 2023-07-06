using MVCStudentproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStudentproject.Controllers
{
    public class StudentController : Controller
    {
  
            // GET: Studen
            public ActionResult Index()
            {

                StudentDBHandler handler = new StudentDBHandler();
                ModelState.Clear();
                return View(handler.GetStudent());

            }

            [HttpGet]
            public ActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public ActionResult Create(StudentModel st)
            {
                if (ModelState.IsValid)
                {
                    StudentDBHandler handler = new StudentDBHandler();
                    if (handler.InsertStudent(st))
                    {
                        ViewBag.Messgae = "Record Inserted";
                        ModelState.Clear();
                    }

                }
                return View();
            }

            [HttpGet]
            public ActionResult Edit(int stdid)
            {
                StudentDBHandler std = new StudentDBHandler();
                return View(std.GetStudent().Find(m => m.StdId == stdid));
            }

            [HttpPost]
            public ActionResult Edit(int stdid, StudentModel st)
            {
                try
                {
                    StudentDBHandler handler = new StudentDBHandler();
                    handler.UpdateStudent(st);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }

            [HttpGet]
            public ActionResult Delete(int StdId)
            {
                StudentDBHandler Handler = new StudentDBHandler();
                return View(Handler.GetStudent().Find(m => m.StdId == StdId));
            }
            [HttpPost]
            public ActionResult Delete(int StdId, StudentModel st)
            {
                try
                {
                    StudentDBHandler db = new StudentDBHandler();
                    db.DeleteStudent(st);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }

            public ActionResult Details(int Stdid)
            {
                StudentDBHandler itemDbHandler = new StudentDBHandler();
                return View(itemDbHandler.GetStudent().Find(m => m.StdId == Stdid));
            }
        }
    }




       