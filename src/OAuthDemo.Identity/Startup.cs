using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Routing;
using Microsoft.Data.Entity;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Security.OAuth;

namespace OAuthDemo.Identity
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // Setup configuration sources
            var configuration = new Configuration();
            configuration.AddJsonFile("config.json");
            configuration.AddEnvironmentVariables();

            app.UseServices(services =>
            {
                // Add EF services to the services container
                services.AddEntityFramework()
                    .AddSqlServer();

                // Configure DbContext
                services.SetupOptions<DbContextOptions>(options =>
                {
                    options.UseSqlServer(configuration.Get("Data:DefaultConnection:ConnectionString"));
                });

                // Add Identity services to the services container
                services.AddIdentitySqlServer<ApplicationIdentityContext, ApplicationUser>()
                    .AddAuthentication();

                // Add MVC services to the services container
                services.AddMvc();

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
            });
        }
    }
}
