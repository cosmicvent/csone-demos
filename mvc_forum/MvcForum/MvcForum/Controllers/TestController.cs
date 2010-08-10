using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcForum.Controllers {
    public class TestController : Controller {
        //
        // GET: /Test/

        public ActionResult Index( string id ) {
            Session["name"] = id;
            return View();
        }

        public ActionResult Dummy() {
            HttpContext.Response.Cookies.Add( new HttpCookie( "myspecialthing", "Hello there" ) );
            return View();
        }

    }
}
