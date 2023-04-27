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
        public void Post([FromBody] Tool myTool)
        {
            System.Console.WriteLine("Inside the post");

            Tool addedTool = new Tool(){ToolId=myTool.ToolId,ToolName=myTool.ToolName,InStock=myTool.InStock,Price=myTool.Price,ToolDescription=myTool.ToolDescription,
            ImageLink=myTool.ImageLink,Deleted=myTool.Deleted};

            addedTool.Save.CreateTool(myTool);
        }

        // PUT: api/Tool/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Tool myTool)
        {
            System.Console.WriteLine("Inside the post");

            Tool addedTool = new Tool(){ToolId=myTool.ToolId,ToolName=myTool.ToolName,InStock=myTool.InStock,Price=myTool.Price,ToolDescription=myTool.ToolDescription,
            ImageLink=myTool.ImageLink,Deleted=myTool.Deleted};

            addedTool.Save.SaveTool(myTool);
        }

        // DELETE: api/Tool/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            System.Console.WriteLine("Inside the delete");
            IDeleteTool deleteTool = new DeleteTool();
            deleteTool.DeleteTool(id);
        }
    }
}
