using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using team11api.Models;
using team11api.Databases;
using team11api.Interfaces;

namespace team11api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {
        // GET: api/Plant
        [HttpGet]
        public List<Plant> Get()
        {
            IReadAllPlants readPlants = new ReadAllPlants();
            List<Plant> myPlants = readPlants.GetAllPlants();
            return myPlants;
        }

        // GET: api/Plant/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Plant
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Plant/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Plant/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
//TEST!!!!
