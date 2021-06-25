using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinIOS.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult PatientEntry()
        {
            return View();
        }
        public ActionResult Patients()
        {
            return View();
        }
    }
}