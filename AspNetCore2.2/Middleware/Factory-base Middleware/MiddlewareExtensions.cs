using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore2._2.Middleware.Factory_base_Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseConvertionalMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ConvertionMiddleware>();
        }

        public static IApplicationBuilder UseFactoryActivatedMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<FactoryActivatedMiddleware>();
        }
    }
}
