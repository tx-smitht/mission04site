using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GradeCalc()
        {
            return View();
        }
    }
}
