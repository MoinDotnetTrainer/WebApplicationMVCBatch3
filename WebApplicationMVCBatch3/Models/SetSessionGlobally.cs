using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplicationMVCBatch3.Models
{
    public class SetSessionGlobally : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var res = context.HttpContext.Session.GetString("LoginName");
            if (res == null)
            {
                context.Result=new RedirectToRouteResult(
                    new RouteValueDictionary
                    {
                        {"controller", "Logins"},
                        {"action", "LoginUser"}
                    }
                );
            }
        }
    }
}
