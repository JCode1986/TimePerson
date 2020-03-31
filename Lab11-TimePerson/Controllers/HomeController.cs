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
            TimePerson.GetPersons(startYear, endYear);
            return null;
        }

        public IActionResult Results(List<TimePerson> persons)
        {
            return View(persons);
        }
    }
}