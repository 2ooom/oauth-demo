using IdentityServer;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly:OwinStartup(typeof(Startup))]
namespace IdentityServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder builder)
        {
            var config = new HttpConfiguration();
            ConfigureWebApi(config);
            ConfigureAuth(builder);
            builder.UseWebApi(config);
        }
    }
}