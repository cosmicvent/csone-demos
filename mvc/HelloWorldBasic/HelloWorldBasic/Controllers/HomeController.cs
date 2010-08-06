using System.Web.Mvc;

namespace HelloWorldBasic.Controllers {
    public class HomeController : Controller {

        public ActionResult Name( string name ) {
            return Content( "Hello " + name + "!" );
        }

        public ActionResult Add( string numbers ) {
            var numbersList = numbers.Split( ' ' );
            int sum = 0;
            foreach ( var number in numbersList ) {
                sum = sum + int.Parse( number );
            }

            return Content( "Your sum is " + sum );
        }


        public ActionResult Calculator() {
            return View();
        }

        public ActionResult Calculate() {
            string firstNumber = Request.Form["first"];
            string secondNumber = Request.Form["second"];

            int result = int.Parse( firstNumber ) + int.Parse( secondNumber );

            ViewData["result"] = result;

            return View( "Result" );
        }
    }
}
