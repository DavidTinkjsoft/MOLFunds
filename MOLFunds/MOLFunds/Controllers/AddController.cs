using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MOLFunds.Controllers
{
    public class AddController : Controller
    {
        // GET: WebCrawler
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WebCrawler() {
            return View();
        }

        public ActionResult OnlineApproval() {
            return View();
        }
    }
}