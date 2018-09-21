using Microsoft.AspNetCore.Mvc;
using System;

namespace Dojo_Survey.Controllers
{
    public class DojoSurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("result")]
        public IActionResult result(string name, string location, string langauge, string comment){
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.langauge = langauge;
            ViewBag.comment = comment;
            Console.WriteLine(ViewBag.name + ViewBag.location + ViewBag.langauge + ViewBag.comment);
            return View("result");
        }
    }
}