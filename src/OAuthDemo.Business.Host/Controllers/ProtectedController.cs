using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OAuthDemo.Business.Host.Controllers
{
    [Authorize]
    public class ProtectedController : Controller
    {
        // GET: /<controller>/
        public IEnumerable<object> Get()
        {
            var identity = User.Identity as ClaimsIdentity;
            return identity.Claims.Select(t => new
            {
                Type = t.Type,
                Value = t.Value,
            });
        }
    }
}
