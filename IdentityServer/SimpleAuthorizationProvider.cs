using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;
using IdentityServer.Data;

namespace IdentityServer
{
    internal class SimpleAuthorizationProvider : OAuthAuthorizationServerProvider
    {
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            return base.ValidateClientAuthentication(context);
        }

        public override Task GrantClientCredentials(OAuthGrantClientCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            /*using (var repo = new AuthorizationRepository())
            {
                var user = await repo.Get(context.)
            }

            return context.Validated()*/
        }
    }
}