﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MOLFunds.Controllers
{
    public class AuditController : Controller
    {
        // GET: Audit
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FundsAuditQuota() {
            return View();
        }
    }
}