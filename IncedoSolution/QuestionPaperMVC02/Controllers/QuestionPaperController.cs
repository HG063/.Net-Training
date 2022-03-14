using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionPaperMVC02.Controllers
{
    public class QuestionPaperController : Controller
    {
        static int score, TotalMarks;
        List<string> answers = new List<string> { "Blue", "Mango Bite", "Fastrack", "Mango", "All of the Above", "Rose", "Audi", "Duke", "All of the Above", "Pepsi" };
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string name, bool ch)
        {
            if (name==null)
            {
                ViewBag.msg = "Please Provide Your Name, Thank you!";
                return View();
            }
            if (ch) 
            {
                ViewBag.msg1 = $"Hi {name}, You Have Read The Instructions. \n Now you can start the Quiz!";
                ViewBag.action = "Quiz";
                ViewBag.start = "Go to Quiz";
            }
            else
            {
                ViewBag.msg = "Please Read The Instructions and Acknowledge It.";
                ViewBag.action = "Index";
                ViewBag.start = "";
            }
            return View();
        }
        [HttpGet]
        public IActionResult Quiz()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Quiz(List<string> ans)
        {
            score = 0;
            if (ans.Count != answers.Count)
            {
                ViewBag.msg = "Please Attempt All The Questions. Thank you!";
            }
            else
            {
                for (int i = 0; i < answers.Count; i++)
                {
                    if (answers[i] == ans[i])
                        score += 1;
                }
                ViewBag.score = score;
            }
            return View();
        }
        [HttpGet]
        public IActionResult Quiz_Score()
        {
            TotalMarks = answers.Count;
            ViewBag.score = score;
            ViewBag.totalmarks = TotalMarks;
            return View();
        }
        
    }
}
