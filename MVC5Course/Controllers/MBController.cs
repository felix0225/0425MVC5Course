using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class MBController : BaseController
    {
        // GET: MB
        public ActionResult Index()
        {
            ViewData["MyClient"] = db.Client.Find(100);

            ViewData.Model = db.Product.Find(1);

            return View();
        }

        public ActionResult TempData1()
        {
            ViewData["Message1"] = "Hello World 1";
            TempData["Message2"] = "Hello World 2";
            Session["Message3"] = "Hello World 3";

            return RedirectToAction("TempData2");
        }
        public ActionResult TempData2()
        {
            ViewBag.Message1 = ViewData["Message1"];
            ViewBag.Message2 = TempData["Message2"];
            ViewBag.Message3 = Session["Message3"];

            return View();
        }
    }
}