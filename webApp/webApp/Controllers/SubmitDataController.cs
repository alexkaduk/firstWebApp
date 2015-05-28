using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webApp.Models;

namespace webApp.Controllers
{
    public class SubmitDataController : Controller
    {
        //
        // GET: /SubmitData/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateMenu()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult CreateMenu(int id, string text, double price, string category)
        //{
        //    var m = new Menu
        //    {
        //        Id = id,
        //        Text = text,
        //        Price = price
        //    };
        //    ViewBag.Info = string.Format("menu created: {0}, Price: {1}, category: {2}", m.Text, m.Price, m.Category);
        //    return View("Index");
        //}
        [HttpPost]
        public ActionResult CreateMenu(Menu m)
        {
            ViewBag.Info = string.Format("menu created: {0}, Price: {1}, category: {2}", 
                m.Text, m.Price, m.Category);
            return View("Index");
        }

    }
}
