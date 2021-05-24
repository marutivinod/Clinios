using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinIOS.Controllers
{
    public class TirageController : Controller
    {
        // GET: Tirage
        [Authorize]
        public ActionResult TirageCalc()
        {
            return View();
        }
    }
}