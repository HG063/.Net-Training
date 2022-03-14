using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppService01.Controllers
{
    public class Person
    {
        public int Id { get; set; }
        public String PName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // GET: api/<PersonController>
        List<Person> person = new List<Person>
        {
            new Person{ Id=101,PName="Sita",Age=23,City="Delhi"},
            new Person{ Id=102,PName="Geeta",Age=20,City="Lucknow"},
            new Person{ Id=103,PName="Babita",Age=21,City="Kolkata"},
        };
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return person;
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
             return person.Single(x => x.Id == id);
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
