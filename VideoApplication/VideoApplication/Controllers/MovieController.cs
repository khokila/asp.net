using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoApplication.Models;

namespace VideoApplication.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Id = 001,Name = "James Bond 007"};
            return View(movie);
        }
        public ActionResult Edit(int id)
        {
            return Content("id ="+ id);
        }
    }
}