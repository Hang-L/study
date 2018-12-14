using AspNetCore2._2.Data;
using AspNetCore2._2.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore2._2.Middleware.Factory_base_Middleware
{
    public class FactoryActivatedMiddleware : IMiddleware
    {
        private readonly AppDbContext _db;

        public FactoryActivatedMiddleware(AppDbContext db)
        {
            _db = db;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var keyValue = context.Request.Query["key"];
            if (!string.IsNullOrEmpty(keyValue))
            {
                _db.Add(new Request {
                    DT = DateTime.Now,
                    MiddlewareActivation = "FactoryActivatedMiddleware",
                    Value = keyValue
                });
                await _db.SaveChangesAsync();
            }
            await next(context);
        }
    }
}
