using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.ActionFilters
{
    public class LoggerAttribute :ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Trace.TraceInformation("Logger Begion");
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Trace.TraceInformation("Logger End");
            base.OnActionExecuted(filterContext);
        }
    }
}