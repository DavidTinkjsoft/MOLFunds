﻿using System;
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

        public ActionResult SecuritiesMaintain() {
            return View();
        }

        public ActionResult SecuritiesInvestment() {
            return View();
        }
    }
}