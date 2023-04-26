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
    public class FormController : ControllerBase
    {
        // GET: api/Form
        [HttpGet]
        public List<Form> Get()
        {
            IReadAllForms getForms = new ReadAllForms();
            List<Form> myForms = getForms.GetAllForms();
            return myForms;
        }

        // GET: api/Form/5
        [HttpGet("{id}", Name = "GetForm")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Form
        [HttpPost]
        public void Post([FromBody] Form myForm)
        {
            System.Console.WriteLine("Inside the post");
            Form newForm = new Form(){FormId=myForm.FormId,Username=myForm.Username,IndoorOutdoor=myForm.IndoorOutdoor,SunExposure=myForm.SunExposure,Soil=myForm.Soil};

            newForm.Save.CreateForm(newForm);
            System.Console.WriteLine(newForm);
        }

        // PUT: api/Form/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Form/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
