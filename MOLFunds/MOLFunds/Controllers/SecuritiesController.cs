using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MOLFunds.Controllers
{
    public class SecuritiesController : Controller
    {
        // GET: Securities
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SecuritiesMaintain()
        {
            return View();
        }

        public ActionResult Securities60Average()
        {
            return View();
        }

<<<<<<< HEAD
        public ActionResult SecuritiesInvestment() {
=======
        public ActionResult SecuritiesCapitalStockReport() {
            return View();
        }

        public ActionResult TransactionTotalReport() {
>>>>>>> 934b639fe8dc70285c1562da38aaa80008c4f7df
            return View();
        }
    }
}