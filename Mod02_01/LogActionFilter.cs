using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics; //Debug.WriteLine
using System.Web.Routing;
namespace Mod02_01
{
    public class LogActionFilter :ActionFilterAttribute
    {
        //Action執行中
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //base.OnActionExecuting(filterContext);
            Debug.WriteLine("The Event Fired: OnActionExecuting");
        }
        //Action執行完成
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //base.OnActionExecuted(filterContext);
            Debug.WriteLine("The Event Fired: OnActionExecuted");
        }
        //接收result中
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //base.OnResultExecuting(filterContext);
            Debug.WriteLine("The Event Fired: OnResultExecuting");
        }
        //接收result完成
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //base.OnResultExecuted(filterContext);
            Debug.WriteLine("The Event Fired: OnResultExecuted");
        }
    }
}