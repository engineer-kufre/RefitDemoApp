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
            new Guest { Id = 2, FirstName = "Luke", LastName = "Skywalker" },
            new Guest { Id = 3, FirstName = "Hans", LastName = "Solo" }
        };

        // GET: api/<GuestsController>
        [HttpGet]
        public IEnumerable<Guest> Get()
        {
            return guests;
        }

        // GET api/<GuestsController>/5
        [HttpGet("{id}")]
        public Guest Get(int id)
        {
            return guests.FirstOrDefault(g => g.Id == id);
        }

        // POST api/<GuestsController>
        [HttpPost]
        public void Post([FromBody] Guest guest)
        {
            guests.Add(guest);
        }

        // PUT api/<GuestsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Guest guest)
        {
            var guestToRemove = guests.FirstOrDefault(g => g.Id == id);
            if(guestToRemove != null)
            {
                guests.Remove(guestToRemove);

                guests.Add(guest);
            }
        }

        // DELETE api/<GuestsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var guestToRemove = guests.FirstOrDefault(g => g.Id == id);
            if (guestToRemove != null)
            {
                guests.Remove(guestToRemove);
            }
        }
    }
}
