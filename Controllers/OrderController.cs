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
    public class OrderController : ControllerBase
    {
        // GET: api/Order
        [HttpGet]
        public List<Order> Get()
        {
            IReadAllOrders readOrders = new ReadAllOrders();
            List<Order> myOrders = readOrders.GetAllOrders();
            return myOrders;
        }

        // GET: api/Order/5
        [HttpGet("{id}", Name = "GetOrder")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Order
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Order/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Order/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
