using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp01.Controllers
{
    public class PostbackDemoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.message = "Hello, Welcome!";
            return View();
        }
        [HttpPost]
        public IActionResult Index(string s)
        {
            ViewBag.message = "Hello, Welcome Back!";
            return View();
        }
        [HttpGet]
        public IActionResult Ex01()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ex01(string v1)
        {
            ViewBag.msg = v1 + " is clicked!";
            return View();
        }
        [HttpGet]
        public IActionResult Ex02()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ex02(string t1)
        {
            ViewBag.msg = $"Hello : {t1}";
            return View();
        }
    }
}
