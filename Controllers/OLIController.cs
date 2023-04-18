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
    public class OLIController : ControllerBase
    {
        // GET: api/OLI
        [HttpGet]
        public List<OLI> Get()
        {
            IReadAllOLIs getOLIs = new ReadAllOLIs();
            List<OLI> myOLIs = getOLIs.GetAllOLIs();
            return myOLIs;
        }

        // GET: api/OLI/5
        [HttpGet("{id}", Name = "GetOLI")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OLI
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/OLI/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/OLI/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
