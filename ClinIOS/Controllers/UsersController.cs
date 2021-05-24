using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinIOS.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Users()
        {
            return View();
        }

        public ActionResult UsersAddEdit(int id = 0)
        {
            return View(id);
        }
    }
}