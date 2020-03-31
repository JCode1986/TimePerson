using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab11_TimePerson.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Default home route for home page
        /// </summary>
        /// <returns>Generate View</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}