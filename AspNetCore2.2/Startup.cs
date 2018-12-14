using AspNetCore2._2.SingleR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace AspNetCore2._2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddHealthChecks();

            //services.AddTransient<FactoryActivatedMiddleware>();
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Register the Swagger generator middleware
            app.UseStaticFiles();
            app.UseSignalR(route=> {
                route.MapHub<SingleRHub>("/chat");
            });
            app.UseMvc();
            //app.Use((context, next) => {
            //    var culture = context.Request.Query["culture"];
            //    if (!string.IsNullOrEmpty(culture))
            //    {
            //        var cul = new CultureInfo(culture);
            //        CultureInfo.CurrentCulture = cul;
            //        CultureInfo.CurrentUICulture = cul;
            //    }
            //    return next();

            //});
            //app.UserRequestCulture();
            //app.UseConvertionalMiddleware();
            //app.UseFactoryActivatedMiddleware();
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync($"Hello {CultureInfo.CurrentCulture.DisplayName}");
            //});

        }
    }
}
