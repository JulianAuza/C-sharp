using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("{fName}/{lName}/{age}/{food}")]
        public JsonResult CallingCard(string fName, string lName, int age, string food)
        {
            var AnonObject = new {
                FirstName = fName,
                LastName = lName,
                Age = age,
                FavoriteFood = food
            };
        return Json(AnonObject);
        }

        
    }
}