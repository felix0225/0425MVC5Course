using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class AFController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //[HandleError]
        //public ActionResult ShowError()
        //{
        //    throw new Exception("OK");
        //    return View();
        //}

        [HandleError(ExceptionType = typeof(ArgumentException), View = "Error.Argument")]
        public ActionResult ShowError(string type)
        {
            if (type == "1")
            {
                throw new ArgumentException("MyBad");
            }
            else
            {
                throw new Exception("OK");
            }

            return View();
        }
    }
}