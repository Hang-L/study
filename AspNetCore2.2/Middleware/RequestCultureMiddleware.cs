using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore2._2.Middleware
{
    public class RequestCultureMiddleware
    {
        private readonly RequestDelegate _next;
        public RequestCultureMiddleware(RequestDelegate requestDelegate)
        {
            _next= requestDelegate;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            var cultureInfo = httpContext.Request.Query["culture"];
            if (!string.IsNullOrEmpty(cultureInfo))
            {
                var culture = new CultureInfo(cultureInfo);
                CultureInfo.CurrentCulture = culture;
                CultureInfo.CurrentUICulture = culture;
            }
            await _next(httpContext);
        }
    }
}
