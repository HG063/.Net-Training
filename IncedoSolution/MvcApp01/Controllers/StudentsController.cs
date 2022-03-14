using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcApp01.Models;

namespace MvcApp01.Controllers
{
    public class StudentsController : Controller
    {
        StudentBO context = new StudentBO();
        public IActionResult Index()
        {
            List<StudentModel> students = context.GetAllStudents();
            ViewBag.students = students;
            return View();
        }
    }
}
