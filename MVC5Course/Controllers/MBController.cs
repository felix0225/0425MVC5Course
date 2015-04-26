using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Course.Models;

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
        public ActionResult Simple1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Simple1(String UserName, String Password)
        {
            return Content("Simple1:" + UserName +" " + Password);
        }
        public ActionResult Simple2()
        {
            return View("Simple1");
        }
        [HttpPost]
        public ActionResult Simple2(FormCollection form)
        {
            return Content("Simple2:" + form["UserName"] + " " + form["Password"]);
        }
        public ActionResult Complex1()
        {
            return View("Simple1");
        }
        [HttpPost]
        public ActionResult Complex1(Simple1ViewModels item)
        {
            return Content("Complex1:" + item.UserName + " " + item.Password);
        }
        public ActionResult Complex2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Complex2(Simple1ViewModels item1, Simple1ViewModels item2)
        {
            return Content("Complex2:" + item1.UserName + " " + item2.Password + " | " + item1.UserName + " " + item2.Password);
        }
        public ActionResult Complex3()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Complex3(
            [Bind(Prefix = "item")]
            Simple1ViewModels item)
        {
            return Content("Complex3:" + item.UserName + " " + item.Password);
        }
        public ActionResult Complex4()
        {
            var data = from p in db.Client
                select new Simple1ViewModels()
                {
                    UserName = p.FirstName,
                    Password = p.LastName,
                    Age = 18
                };

            return View(data.Take(10));
        }
        [HttpPost]
        public ActionResult Complex4(IList<Simple1ViewModels> smList)
        {
            return Content("");
        }
    }
}