using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;
using ResourceServer.Business;

namespace ResourceServer
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseServices(servicies =>
            {
                servicies.AddMvc();
                servicies.AddScoped<IOrderService, OrderService>();
            });
            
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
