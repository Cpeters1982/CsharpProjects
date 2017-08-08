using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_prac.Controllers
{
    public class PracController: Controller
    {
        // [HttpGet]
        // [Route("")]
        // public string Index()
        // {
        //     return "Hello World!";
        // }
        // [HttpGet]
        // [Route("FName")]
        // public string FName()
        // {
        //     return "Chris!";
        // }
        // [HttpGet]
        // [Route("LName")]
        // public string LName()
        // {
        //     return "Peters!";
        // }
        // [HttpGet]
        // [Route("Age")]
        // public int Age()
        // {
        //     return 34;
        // }
        [HttpGet]
        [Route("card/{FName}/{LName}/{Age}/{FavColor}")]
        public JsonResult CallCard(string FName, string LName, int Age, string FavColor)
        {
            return Json(new {FirstName = FName, LastName = LName, Age = Age, FavoriteColor = FavColor});
        }
    }
}