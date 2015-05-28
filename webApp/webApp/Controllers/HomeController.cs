using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string Hello()
        {
            return "Hello, ASP.NET MVC";
        }

        public string Greeting(string name)
        {
            return HttpUtility.HtmlEncode("Hello, " + name);
        }

        public ActionResult RedirectToIbud()
        {
            return Redirect("http://ibud.ua");
        }
    }
}
