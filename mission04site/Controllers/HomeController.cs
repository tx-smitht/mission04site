using Microsoft.AspNetCore.Mvc;
using mission04site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission04site.Controllers
{
    public class HomeController : Controller
    {

        // Render the index page
        public IActionResult Index()
        {
            return View();
        }

        // Render the GradeCalc page
        [HttpGet]
        public IActionResult GradeCalc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GradeCalc(GradeCalculatorModel model)
        {
            return View();
        }

    }
}
