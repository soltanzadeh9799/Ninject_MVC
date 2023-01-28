using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ninject_MVC.Controllers
{
    public class HomeController : Controller
    {
        private IEmailSender sender;
        public HomeController(IEmailSender sender)
        {
            this.sender = sender;
        }

        public ActionResult Index()
        {
            ViewBag.Message = sender.SendEmail("s.soltanzadeh9799@Gmail.com", "Dependency Injection");
            return View();
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
    }
}