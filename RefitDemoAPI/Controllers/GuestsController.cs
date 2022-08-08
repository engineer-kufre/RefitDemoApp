using Microsoft.AspNetCore.Mvc;
using RefitDemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefitDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private static List<Guest> guests = new List<Guest>()
        {
            new Guest { Id = 1, FirstName = "Darth", LastName = "Vader" },
            new Guest { Id = 1, FirstName = "Luke", LastName = "Skywalker" },
            new Guest { Id = 1, FirstName = "Hans", LastName = "Solo" }
        };

        // GET: api/<GuestsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GuestsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GuestsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GuestsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GuestsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
