using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Routing;

namespace OAuthDemo.Business.Host
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseServices(t =>
            {
                t.AddMvc();
                t.AddScoped<IOrderService, OrderService>();
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "api",
                    template: "{controller}/{id?}");
            });
        }
    }
}
