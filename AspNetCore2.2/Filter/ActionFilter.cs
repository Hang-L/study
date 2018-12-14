using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.IdentityModel.Protocols.WsFederation.WsFederationConstants;

namespace AspNetCore2._2.Filter
{
    public class ActionFilter : Attribute,IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("action filter excuting");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            context.Result = new OkResult();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("action filter excuted");
        }
    }
}
