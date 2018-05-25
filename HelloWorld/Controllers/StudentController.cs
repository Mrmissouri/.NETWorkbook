using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class StudentController : Controller
    {
        private readonly HelloWorldContext _context;

        public StudentController(HelloWorldContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.students.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {

            Student model = new Student();
            return View(model);

            //Create an instance of the DataContext Class
            //in order to properly connect to our database
            //HelloWorldContext context = new HelloWorldContext();


        }
        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View("Details", model);
        }

        public IActionResult Details(Student model)
        {
            return View(model);
        }
    }
}
