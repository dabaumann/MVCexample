using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCexample.Controllers
{
    public class AuthorizationController : Controller
    {
        public ActionResult NewUser()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

      
    }
}