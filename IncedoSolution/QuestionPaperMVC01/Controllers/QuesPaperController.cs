using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionPaperMVC.Controllers
{
    public class QuesPaperController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(List<string> ans)
        { 
            List<string> answers = new List<string> { "Blue","Mango Bite","Fastrack","Mango","All of the Above","Rose","Audi","Duke","All of the Above","Pepsi"};
            int score = 0;
            if (ans.Count != answers.Count)
            {
                ViewBag.msg = "Please Attempt all the question. Thank you!";
                return View();
            }
            else
            {
                for (int i = 0; i < answers.Count; i++)
                {
                    if (answers[i] == ans[i])
                        score += 1;
                }
                ViewBag.score = score;
                return View();
            }
        }
    }
}
