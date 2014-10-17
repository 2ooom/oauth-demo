﻿using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;

namespace ResourceServer
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseServices(servicies => { servicies.AddMvc(); });
            // Add MVC to the request pipeline
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });

                routes.MapRoute(
                    name: "api",
                    template: "{controller}/{id?}");
            });
        }
    }
}
