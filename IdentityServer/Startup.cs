using IdentityServer;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(Startup))]
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
            var oauthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                //AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),
                Provider = new SimpleAuthorizationProvider()
            };

            builder.UseOAuthAuthorizationServer(oauthServerOptions);
        }
    }
}