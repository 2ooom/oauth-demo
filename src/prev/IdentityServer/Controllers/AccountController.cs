using IdentityServer.Models;
using System.Web.Http;
using IdentityServer.Data;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace IdentityServer.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        private AuthorizationRepository authRepository;

        public AccountController()
        {
            authRepository = new AuthorizationRepository();
        }

        [Route("Register")]
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
                return false;
            }
            foreach(var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error);
            }
            return true;
        }
    }
}