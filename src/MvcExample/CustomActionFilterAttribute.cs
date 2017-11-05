using System;
using System.Linq;
using System.Web.Mvc;
using MvcExample.Dependencies;

namespace MvcExample
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomActionFilterAttribute : ActionFilterAttribute
    {
        public IFilterDependency Dependency { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // This filter adds a value from the dependency to the current context
            // so the controller can grab it and pass it to the view.
            filterContext.HttpContext.Items["filterValue"] = this.Dependency.CurrentTicks;
        }
    }
}