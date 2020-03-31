using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab11_TimePerson.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab11_TimePerson.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Default home route for home page
        /// </summary>
        /// <returns>Generate View</returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int startYear, int endYear)
        {
            // To redirect to our results action with the "results" of our query
            return RedirectToAction("Results", new { startYear, endYear });
        }

        [HttpGet]

        public IActionResult Results(int startYear, int endYear)
        {
            //return View(persons);
            return View(TimePerson.GetPersons(startYear, endYear));
        }
    }
}