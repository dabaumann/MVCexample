using MVCexample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCexample.Controllers
{
    public class HomeController : Controller
    {

        public IDataService dataService;

        public HomeController(IDataService _dataService)
        {
            dataService = _dataService;
        }

        public ActionResult Index()
        {
            return View(dataService.getAccounts());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult AccountCreation(string user, int account)
        {
            var model = new
            {
                success = dataService.CreateAccount(user, account),
                account = account
            };
            return Json(model);
        }
    }
}