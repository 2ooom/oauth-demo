using Microsoft.Owin.Security.Cookies;
using Owin;

namespace IdentityServer
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            // Enable the Application Sign In Cookie.
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Application",
                CookieSecure = CookieSecureOption.Always,
            });
        }
    }
}