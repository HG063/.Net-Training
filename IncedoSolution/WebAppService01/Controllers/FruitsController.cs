using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppService01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        static List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Mango", "Pineapple" };
        // GET: api/<FruitsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return fruits;
        }

        // GET api/<FruitsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return fruits[id];
        }

        // POST api/<FruitsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            fruits.Add(value);
        }

        // PUT api/<FruitsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FruitsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
