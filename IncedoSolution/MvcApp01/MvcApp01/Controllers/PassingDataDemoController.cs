using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp01.Controllers
{
    public class PassingDataDemoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["name"] = "Harshit Gupta";
            ViewBag.city = "Lucknow";
            return View();
        }
        public IActionResult Ex01()
        {
            int v1 = 100;
            string v2 = "message";
            double v3 = 7.27;
            ViewBag.v1 = v1;
            ViewBag.v2 = v2;
            ViewBag.v3 = v3;
            return View();
        }
        public IActionResult Ex02()
        {
            string[] sweets = new string[] { "Laddu", "Barfi", "Peda" };
            ViewBag.sweets = sweets;
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Pineapple" };
            ViewBag.fruits = fruits;
            return View();
        }
    }
}
