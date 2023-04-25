using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASPRazor_Init_Route
{
    public class Startup
    {
        // Author Tran Dinh Khanh
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages().AddRazorPagesOptions((options) =>
            {
                options.RootDirectory = ("/Pages");
                options.Conventions.AddPageRoute("/FirstPage", "/trang-dau-tien.html");

            });

            services.Configure<RouteOptions>(routeOptions =>
            {
                routeOptions.LowercaseUrls = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages(); // FirstPage.cshtml URL=FirstPage
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
/*
 Razor page (.cshtml) = html + c#
 Engine Razor -> bien dich .cshtml -> tra ve Response
 @page "url
 @bien,phuong thuc,(bieuthuc)
 @{
    //code
 }
 @for()
 <HTML></HTML>

Rewrite Url
TagHelper -> Html
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers    
**/