using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace DojoDachi.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetObjectFromJson<dachi>("dachi") == null)
            {
                HttpContext.Session.SetObjectAsJson("dachi", new dachi());
            }
            ViewBag.dachi = HttpContext.Session.GetObjectFromJson<dachi>("dachi");
            return View();
        }
        [HttpGet]
        [Route("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Route("process")]
        public IActionResult Process(string Activity)
        {
            dachi curDachi = HttpContext.Session.GetObjectFromJson<dachi>("dachi");
            if (Activity == "Feed")
            {
                curDachi.feed();
            }
            else if (Activity == "Work")
            {
                curDachi.work();
            }
            else if (Activity == "Play")
            {
                curDachi.play();
            }
            else if (Activity == "Sleep")
            {
                curDachi.sleep();
            }
            HttpContext.Session.SetObjectAsJson("dachi", curDachi);
            // ViewBag.dachi = curDachi;
            return RedirectToAction("Index");
        }
    }
}
