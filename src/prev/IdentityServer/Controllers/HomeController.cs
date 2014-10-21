using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace IdentityServer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var user = Request.GetOwinContext().Authentication.User;
            var nameClaim = user.Claims.FirstOrDefault(t => t.Type == ClaimTypes.Name);
            if (nameClaim != null)
            {
                ViewBag.UserName = nameClaim.Value;
            }
            return View();
        }

        [Authorize]
        public ActionResult Secret()
        {
            return Content("Secret");
        }
    }
}