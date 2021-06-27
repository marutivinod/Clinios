using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ClinIOS.Models;


namespace ClinIOS.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
       
        DataAccess da = new DataAccess();
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var mod = da.CheckLogin(model);

                if (mod == null)
                {
                    ModelState.AddModelError("", "Not valid.");
                    return View();
                }
                else
                {
                    int Uid = mod.Id.Value;
                    FormsAuthentication.SetAuthCookie(mod.UserFullName, true);

                    //da.UserExit(mod.Id.Value);
                    //GlobalData.ValidationKey = Guid.NewGuid().ToString();
                    //da.UserEntry(mod.Id.Value);
                    //da.ActivateUser(Uid); 


                    //var curec = da.GetRecord<CurrentStatu>("Id", mod.ID.ToString());
                    //da.DeleteRecord<CurrentStatu>(curec);

                    //Session["UserId"] = mod.ID;
                    System.Web.HttpContext.Current.Session.Add("UserId", mod.Id.Value);
                    // i comment 14-19-19 
                    // string roles = 

                    //da.SetValue("UserId", mod.Id.ToString(), mod.Id.Value);
                    //da.SetValue("UserRoles", da.GetRecords<Role_Master>().SingleOrDefault(x => x.RoleId == mod.RoleId).Description.ToLower(), mod.Id.Value);
                    //da.SetValue("RoleId", mod.RoleId.Value.ToString(), mod.Id.Value);
                    //da.UserLog(mod.Id.Value, mod.RoleId.Value);
                    //da.SetValue("AuthMode", da.GetRecords<ControlTable>().FirstOrDefault().AuthMode.ToString(), mod.Id.Value);
                    //// da.SetValue("UserRole", roles.Contains("admin") ? "Admin" : "", mod.ID); i ,comment 14-19-19 
                    //da.SetValue("UserName", mod.UserName, mod.Id.Value);
                    return RedirectToAction( "Patients","Patient");
                    //return RedirectToAction("SelectRole", "Home", new { Id =mod.ID});// pass userId from the database
                }
            }
            else
            {
                ModelState.AddModelError("", "Not valid.");
            }
            return View();
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login", "Account");
        }

        [AllowAnonymous]
        public ActionResult ForgotPaswd()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult ForgotPaswdResult()
        {
            return View();
        }
    }
}