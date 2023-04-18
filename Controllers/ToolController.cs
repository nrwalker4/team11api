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
    public class ToolController : ControllerBase
    {
        // GET: api/Tool
        [HttpGet]
        public List<Tool> Get()
        {
            IReadAllTools readTools = new ReadAllTools();
            List<Tool> myTools = readTools.GetAllTools();
            return myTools;
        }

        // GET: api/Tool/5
        [HttpGet("{id}", Name = "GetTool")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tool
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Tool/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Tool/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}