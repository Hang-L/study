using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore2._2.Filter
{
    public class AsyncActionFilter : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            context.Result = new JsonResult("action filter");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("async action excuting......");
            await next();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("async action excuted......");
        }
    }
}
