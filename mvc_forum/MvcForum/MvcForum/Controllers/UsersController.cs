using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcForum.Models;
using System.Web.Security;

namespace MvcForum.Controllers {
    public class UsersController : Controller {

        MvcForumDataContext _dataContext;

        public UsersController() {
            _dataContext = new MvcForumDataContext();
        }

        public ActionResult SignUp() {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp( FormCollection form ) {
            User user = new User();
            user.UserName = form["username"];
            string hashedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile( form["password"], "SHA1" );
            user.Password = hashedPassword;
            user.CreatedOn = DateTime.Now;
            _dataContext.Users.InsertOnSubmit( user );
            _dataContext.SubmitChanges();
            TempData["success"] = "Registered user successfully";
            return Redirect( "/" );
        }

    }
}
