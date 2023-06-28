using bankdropdown.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Transactions;

namespace bankdropdown.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Account ac)
        {
            int bal = 1000;
            int actno = ac.Accountno;
            int amount = ac.Ammount;
            var tt = ac.gettranstype;
            string tt1 = tt.ToString();
            switch (tt1)
            {
                case "deposit":
                    bal = bal + amount;
                    break;
                case "withdrawl":
                    bal = bal - amount;

                    break;
            }
            ViewBag.accountno = actno;
            ViewBag.balance = bal;

            return View();
        }
    }
}