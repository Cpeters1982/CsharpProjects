using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RESTauranter.Models;


namespace RESTauranter.Controllers
{
    public class ReviewController : Controller
    {
        private RestContext _context;

        public ReviewController(RestContext context)
        {
            _context = context;
        }

        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {

            return View();
        }


        [HttpPost]
        [Route("create_review")]
        public IActionResult CreateReview(Review review)

        {
            if (ModelState.IsValid){

            System.Console.WriteLine(review);
            review.created_at = DateTime.Now;
            review.updated_at = DateTime.Now;
            _context.Add(review);
            _context.SaveChanges();
            return RedirectToAction("Reviews");
            }
            System.Console.WriteLine("ERRORS!");
            return View("Index");
        }


        [HttpGet]
        [Route("reviews")]
        public IActionResult Reviews()
        {
            // List<Review> AllReviews = _context.Reviews.ToList();
            // ViewBag.Reviews = AllReviews;

            ViewBag.reviews = _context.Reviews.OrderByDescending(r => r.created_at);
            return View();
        }
    }
}
