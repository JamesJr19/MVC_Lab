using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Lab.Models;

namespace MVC_Lab.Controllers
{
    public class TripController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MileageForm()
        {
            return View();
        }

        public IActionResult MileageResult(Tripometer trips)
        {
                     return View(trips);
        }
    }
}