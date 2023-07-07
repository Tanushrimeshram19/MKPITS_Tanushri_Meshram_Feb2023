using DropDownExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropDownExample.Models;

namespace DropDownExample.Controllers
{
    public class CountryController : Controller
    {
        // GET: Country
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Details()
        {
            bindState();
            return View();
        }

        public void bindState()
        {
            DataModel1 modelDemo = new DataModel1();
            var state = modelDemo.StateTables.ToList();
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Text = "--Select State--", Value = "0" });

            foreach (var m in state)
            {

                li.Add(new SelectListItem { Text = m.StateName, Value = m.StateId.ToString() });
                ViewBag.state = li;

            }
        }

        public JsonResult getCity(int id)
        {
            DataModel1 modelDemo = new DataModel1();
            var ddlCity = modelDemo.CityTables.Where(x => x.StateId == id).ToList();
            List<SelectListItem> licities = new List<SelectListItem>();

            licities.Add(new SelectListItem { Text = "--Select State--", Value = "0" });
            if (ddlCity != null)
            {

                foreach (var x in ddlCity)
                {
                    licities.Add(new SelectListItem { Text = x.CityName, Value = x.CityId.ToString() });
                }
            }
            return Json(new SelectList(licities, "Value", "Text", JsonRequestBehavior.AllowGet));
        }
    }
}