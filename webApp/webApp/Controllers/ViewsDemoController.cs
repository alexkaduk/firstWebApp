using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webApp.Controllers
{
    public class ViewsDemoController : Controller
    {
        //
        // GET: /ViewsDemo/

        public ActionResult Index()
        {
            ViewBag.MyData = "Hello from the controller";
            return View();
        }

    }
}
