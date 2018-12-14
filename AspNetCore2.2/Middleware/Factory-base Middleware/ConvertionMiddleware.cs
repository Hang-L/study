using AspNetCore2._2.Data;
using AspNetCore2._2.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore2._2.Middleware.Factory_base_Middleware
{
    public class ConvertionMiddleware
    {
        private readonly RequestDelegate _next;
        public ConvertionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvoleAsync(HttpContext httpContext,AppDbContext db)
        {
            var keyValue = httpContext.Request.Query["key"];
            if (!string.IsNullOrEmpty(keyValue))
            {
                db.Add(
               new Request
               {
                   DT = System.DateTime.Now,
                   MiddlewareActivation="ConvertionalMIddleware",
                   Value=keyValue
               });
                await db.SaveChangesAsync();
            }
            await _next(httpContext);
        }
    }
}
