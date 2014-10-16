using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using IdentityServer.Models;
using Microsoft.Owin.Security;
using System.Web.Http;
using IdentityServer.Data;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace IdentityServer.Controllers
{
    public class AccountController : ApiController
    {
        private AuthorizationRepository authRepository;

        public AccountController()
        {
            authRepository = new AuthorizationRepository();
        }

        public async Task<IHttpActionResult> Register(LoginViewModel userModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await authRepository.Create(userModel);
            if(HasErrors(result))
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }

        private bool HasErrors(IdentityResult result)
        {
            if(result.Succeeded)
            {
                return true;
            }
            foreach(var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error);
            }
            return false;
        }
    }
}