using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using IdentityServer.Models;
using Microsoft.Owin.Security;

namespace IdentityServer.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Request.GetOwinContext().Authentication.SignOut("Application");
            var claims = new List<Claim> {new Claim(ClaimTypes.Name, loginViewModel.UserName)};
            var identity = new ClaimsIdentity(claims, "Application");
            Request.GetOwinContext().Authentication.SignIn(new AuthenticationProperties {IsPersistent = loginViewModel.RememberMe}, identity);
            return View();
        }

        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut("Application");
            return new EmptyResult();
        }
    }
}