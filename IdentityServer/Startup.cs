using IdentityServer;
using Microsoft.Owin;
using Owin;

[assembly:OwinStartup(typeof(Startup))]
namespace IdentityServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder builder)
        {
            ConfigureAuth(builder);
        }
    }
}