using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IdentityServer.Data
{
    public class AuthorizationRepository
    {
        private UserManager<UserIdentity> manager; 
        private AuthorizationContext context; 
        public AuthorizationRepository()
        {
            context = new AuthorizationContext();
            manager = new UserManager<UserIdentity>(new UserStore<UserIdentity>(context));
        }
    }
}