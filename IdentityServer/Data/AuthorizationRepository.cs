using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using IdentityServer.Models;

namespace IdentityServer.Data
{
    public class AuthorizationRepository : IDisposable
    {
        private UserManager<UserIdentity> manager; 
        private AuthorizationContext context;

        public AuthorizationRepository()
        {
            context = new AuthorizationContext();
            manager = new UserManager<UserIdentity>(new UserStore<UserIdentity>(context));
        }

        public async Task<IdentityResult> Create(LoginViewModel userModel)
        {
            var user = new UserIdentity { UserName = userModel.UserName };
            return await manager.CreateAsync(user, userModel.Password);
        }

        public async Task<UserIdentity> Get(string username, string password)
        {
            return await manager.FindAsync(username, password);
        }

        public void Dispose()
        {
            context.Dispose();
            manager.Dispose();
        }
    }
}