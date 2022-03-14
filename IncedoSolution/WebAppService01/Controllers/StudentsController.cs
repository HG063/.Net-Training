using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppService01.Controllers
{
    public class Student
    {
        public int Id { get; set; }
        public string SName { get; set; }
        public string Course { get; set; }
        public int Fee { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: api/<StudentsController>
        static List<Student> students = new List<Student>
        {
            new Student {Id=101,SName="Ram",Course="EEE",Fee=25000},
            new Student {Id=102,SName="Rajesh",Course="ECE",Fee=30000},
            new Student {Id=103,SName="Arun",Course="CSE",Fee=90000},
            new Student {Id=104,SName="Sita",Course="MCA",Fee=40000},
        };

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return students.Single(x=>x.Id == id);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] Student s)
        {
            students.Add(s);
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student s)
        {
            int index = students.FindIndex(x => x.Id == id);
            students[index] = s;    

        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            int index = students.FindIndex(x => x.Id == id);
            students.RemoveAt(index);
        }
    }
}
