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
        [HttpGet("{id}", Name = "GetPlant")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Plant
        [HttpPost]
        public void Post([FromBody] Plant newPlant)
        {
            System.Console.WriteLine("Inside the post");
            
            Plant addedPlant = new Plant(){PlantId=newPlant.PlantId,PlantName=newPlant.PlantName,PlantType=newPlant.PlantType,Lifespan=newPlant.Lifespan,
            IndoorOutdoor=newPlant.IndoorOutdoor,SunExposure=newPlant.SunExposure,Soil=newPlant.Soil,WateringFreq=newPlant.WateringFreq,ExternalLink=newPlant.ImageLink,
            InStock=newPlant.InStock,Deleted=newPlant.Deleted};
            
            addedPlant.Save.CreatePlant(addedPlant);
        }

        // PUT: api/Plant/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Plant myPlant)
        {
            System.Console.WriteLine("Inside the put");

            Plant addedPlant = new Plant(){PlantId=myPlant.PlantId,PlantName=myPlant.PlantName,PlantType=myPlant.PlantType,Lifespan=myPlant.Lifespan,
            IndoorOutdoor=myPlant.IndoorOutdoor,SunExposure=myPlant.SunExposure,Soil=myPlant.Soil,WateringFreq=myPlant.WateringFreq,ExternalLink=myPlant.ImageLink,
            InStock=myPlant.InStock,Deleted=myPlant.Deleted};

            addedPlant.Save.SavePlant(addedPlant);
        }

        // DELETE: api/Plant/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            System.Console.WriteLine("Inside the delete");
            IDeletePlant deletePlant = new DeletePlant();
            deletePlant.DeletePlant(id);
        }
    }
}