using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        private static Random _rnd = new Random();

        private static List<string> _db = new List<string> {"You look much older than that!", "You look good for someone " +
            "that OLD!","You should not be hanging around little kids!","My first guess would have been 9.","How about you try" +
            " acting your age?", "Do you have a will yet?", "Would you like a bottle?", "Do you need a nap?"};
        [HttpGet]
        public IActionResult Index()
        {
            return View(new SampleViewModel());
        }

        [HttpPost]
        public IActionResult GetResponse(string question, int Age)
        {
            ResponseViewModel model = new ResponseViewModel();

            int index = _rnd.Next(_db.Count);
            var answer = _db[index];

            model.Response = answer;
            model.Age = Age;

            #region OlderCode
            #endregion

            return View(model);
        }

        public IActionResult Customers()
        {
            ViewData["Message"] = "Your customer page.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
