using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp01.Controllers
{
    public class HtmlHelpersDemoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string t1, string b1)
        {
            switch(b1)
            {
                case "Upper":
                    ViewBag.msg = $"{t1.ToUpper()}";
                    break;
                case "Lower":
                    ViewBag.msg = $"{t1.ToLower()}";
                    break;
                case "Length":
                    ViewBag.msg = $"{t1.Length}";
                    break;
            }
            return View();
        }
        [HttpGet]
        public IActionResult Ex01()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ex01(int a, int b, string ch)
        {
            int c = 0;
            switch (ch)
            {
                case "Add":
                    ViewBag.msg = $"Addition of {a} and {b} : {a + b}";
                    break;
                case "Sub":
                    ViewBag.msg = $"Substraction of {a} and {b} : {a - b}";
                    break;
                case "Mul":
                    ViewBag.msg = $"Multiplication of {a} and {b} : {a * b}";
                    break;
                case "Div":
                    ViewBag.msg = $"Division of {a} and {b} : {a / b}";
                    break;
                case "Big":
                    c = a > b ? a : b;
                    ViewBag.msg = $"Biggest of {a} and {b} : {c}";
                    break;
                case "Small":
                    c = a < b ? a : b;
                    ViewBag.msg = $"Biggest of {a} and {b} : {c}";
                    break;
            }
            return View();
        }
        [HttpGet]
        public IActionResult Ex02()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ex02(string t1, string gender)
        {
            if (gender == "Male")
                ViewBag.msg = $"Hello Mr. {t1}";
            else if (gender == "Female")
                ViewBag.msg = $"Hello Miss. {t1}";
            else if (gender == "Others")
                ViewBag.msg = $"Hello {t1}";
            return View();
        }
        [HttpGet]
        public IActionResult Ex03()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ex03(string t1, bool choice)
        {
            if (choice)
                ViewBag.msg = $"Thank you, {t1} for Accepting Terms and Condition!";
            else
                ViewBag.msg = $"{t1}, You must accept Terms and Condition before Proceeding!";
            return View();
        }
    }
}
