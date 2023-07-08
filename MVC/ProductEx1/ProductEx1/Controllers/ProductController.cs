using ProductEx1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductEx1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Details()
        {
            bindCategory();
            return View();
        }

        public void bindCategory()
        {
            ProductModel modelDemo = new ProductModel();
            var state = modelDemo.tblCategories.ToList();
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Text = "--Select Category--", Value = "0" });

            foreach (var m in state)
            {


                li.Add(new SelectListItem { Text = m.catname, Value = m.catid.ToString() });
                ViewBag.state = li;

            }
        }

        public JsonResult getProduct(int id)
        {
            ProductModel modelDemo = new ProductModel();
            var ddlprod = modelDemo.tblProducts.Where(x => x.catid == id).ToList();
            List<SelectListItem> licities = new List<SelectListItem>();

            licities.Add(new SelectListItem { Text = "--Select Product--", Value = "0" });
            if (ddlprod != null)
            {
                foreach (var x in ddlprod)
                {
                    licities.Add(new SelectListItem { Text = x.prodName, Value = x.prodid.ToString() });
                }
            }
            return Json(new SelectList(licities, "Value", "Text", JsonRequestBehavior.AllowGet));
        }
    }
}
   