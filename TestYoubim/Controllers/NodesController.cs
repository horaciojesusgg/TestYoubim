using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestYoubim.Manager;
using TestYoubim.Model;

namespace TestYoubim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NodesController : ControllerBase
    {

        private readonly NodeManager _nodeManager;
        public NodesController(NodeManager nodeManager)
        {
            _nodeManager = nodeManager;
        }

        // GET api/nodes
        [HttpGet]
        public JsonResult getAll()
        {
            var nodes = this._nodeManager.getAll();
            return new JsonResult(nodes);
        }

        // GET api/nodes/5
        [HttpGet("{id}")]
        public ActionResult<JsonResult> GetNodeByGuid(Guid id)
        {
            var node = this._nodeManager.getById(id);
            return new JsonResult(node);
        }

        // POST api/values
        [HttpPost]
        public IActionResult PostNode([FromBody] Node node)
        {
            try {
                Node newNode = this._nodeManager.create(node.IdUser, node.Name, node.VersionFile);
                return Ok(newNode);
            } catch(Exception e)
            {
                return BadRequest(e);
            }
            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult PutNode(Guid id, [FromBody] Node node)
        {
            if (id != node.Id)
            {
                return BadRequest();
            }

            Node result = this._nodeManager.edit(id, node);
            return Ok(result);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult DeleteNode(Guid id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            this._nodeManager.delete(id);
            return Ok();
        }
    }
}
