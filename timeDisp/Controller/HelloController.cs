using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace timeDisp.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        [Route("home")]
        public IActionResult Hello()
        {

            return View("Hello");
            //Both of these returns will render the same view (You only need one!)
        }

        [HttpGet]
        [Route("projects")]
        public IActionResult projects()
        {

            return View("Project");
            //Both of these returns will render the same view (You only need one!)
        }

        [HttpGet]
        [Route("contact")]
        public IActionResult contact()
        {

            return View("Contact");
            //Both of these returns will render the same view (You only need one!)
        }
        
    }
}