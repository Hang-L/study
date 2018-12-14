using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AspNetCore2._2.Filter
{
    public class ResourceFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("resource filter excuting......");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            //context.Result=new Microsoft.AspNetCore.Mvc.JsonResult( "aaaa");
           
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("resource filter excuted....");
        }
    }
}
