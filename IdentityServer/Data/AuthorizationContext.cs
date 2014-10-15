using Microsoft.AspNet.Identity.EntityFramework;

namespace IdentityServer.Data
{
    public class AuthorizationContext : IdentityDbContext<UserIdentity>
    {
        public AuthorizationContext()
            :base("AuthorizationContext")
        {
            
        }
    }
}