using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace team11api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class plantController : ControllerBase
    {
        // GET: api/plant
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/plant/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/plant
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/plant/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/plant/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
