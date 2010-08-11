using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcForum.Models;
using System.Web.Security;

namespace MvcForum.Controllers {
    public class SessionsController : Controller {


        MvcForumDataContext _dataContext;

        public SessionsController() {
            _dataContext = new MvcForumDataContext();
        }
        public ActionResult New() {
            return View();
        }

        public ActionResult Create( FormCollection form ) {
            User user = _dataContext.Users.FirstOrDefault( x => x.UserName == form["username"] );

            string hashedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile( form["password"], "SHA1" );
            if ( user == null || user.Password != hashedPassword ) {
                TempData["error"] = "invalid username or password";
                return View( "New" );
            }

            TempData["success"] = "Successfully logged in";
            FormsAuthentication.RedirectFromLoginPage( user.UserName, false ); //It sets up the ASP.NET User object
            return Redirect( "/" );
        }

        public ActionResult Destroy() {
            FormsAuthentication.SignOut();
            return Redirect( "/" );
        }
    }
}
