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

        public ActionResult SecuritiesInvestment()
        {
            return View();
        }
        public ActionResult SecuritiesCapitalStockReport() {
            return View();
        }

        public ActionResult TransactionTotalReport() {
            return View();
        }

        public ActionResult SecuritiesBond()
        {
            return View();
        }
    }
}