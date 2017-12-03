using IdentityTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityTesting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //Typical change from GitHub
            var model = new AboutModel
            {
                BasicDescription = "This is to test ASP.NET Identity",
                MoreDescription = "(as well as Visual Studio integration with Git, which is something you're not gonna see in the application code it self)"
            };

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
