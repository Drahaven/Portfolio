using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class ExperiencesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ExperiencesPro()
        {
            return View();
        }

        public IActionResult Formations()
        {
            return View();
        }




    }
}
