using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Lab.Models;

namespace MVC_Lab.Controllers
{
    public class MadlibController : Controller
    {
        MadlibWords currentMadlib = new MadlibWords
        {
            PartsOfSpeech = new List<string> { "noun", "adjective", "celebrity", "noun", "verb", "adverb", "time" }
        };

        public IActionResult MadlibForm()
        {

            return View(currentMadlib);
        }


    }
}