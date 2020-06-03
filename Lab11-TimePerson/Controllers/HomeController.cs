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


        /// <summary>
        /// Posting users input
        /// </summary>
        /// <param name="startYear"></param>
        /// <param name="endYear"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(int startYear, int endYear)
        {

            if (startYear <= endYear)
            {
                // To redirect to our results action with the "results" of our query
                return RedirectToAction("Results", new { startYear, endYear });
            }
            else
            {
                return View();
            }
        }

        /// <summary>
        /// Returns list of person times based on user input on start year and end year
        /// </summary>
        /// <param name="startYear">int</param>
        /// <param name="endYear">int</param>
        /// <returns>List of people</returns>
        [HttpGet]

        public IActionResult Results(int startYear, int endYear)
        {
            return View(TimePerson.GetPersons(startYear, endYear));
        }
    }
}