using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppService01.Controllers
{
    public class Employee
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/<EmployeesController>
        List<Employee> employees = new List<Employee>
        {
            new Employee{ Id=101,EName="Raju",Job="Trainer",Salary=20000},
            new Employee{ Id=102,EName="Rajiv",Job="Hacker",Salary=90000},
            new Employee{ Id=103,EName="Rakesh",Job="Developer",Salary=95000},
            new Employee{ Id=104,EName="Ramesh",Job="Assistant",Salary=10000},
        };
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return employees.Single(x => x.Id == id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
