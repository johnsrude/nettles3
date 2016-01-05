using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using NettlesApi.Filters;
using NettlesApi.Models;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NettlesApi.Controllers
{
    [Route("api/nettles")]
    [GenericExceptionFilter]
    public class NettlesController : Controller
    {
        public NettlesController(INettlesRepository repository)
        {
            Repository = repository;
        }

        [FromServices]
        public INettlesRepository Repository { get; set; }

        //--------------------------- GET ---------------------

        // GET: api/values
        [HttpGet("shows")]
        public IActionResult GetShows()
        {
            var item = Repository.GetShows();
            if (!item.Any()) return HttpNotFound();
            return new ObjectResult(item);
        }

        [HttpGet("show/{id}", Name = "GetShow")]
        public IActionResult GetShow(int id)
        {
            var item = Repository.GetShow(id);
            if (!item.Any()) return HttpNotFound();
            return new ObjectResult(item);
        }

        [HttpGet("callers")]
        public IActionResult GetCallers()
        {
            var item = Repository.GetCallers();
            if (!item.Any()) return HttpNotFound();
            return new ObjectResult(item);
        }

        [HttpGet("show/{id}/callers")]
        public IActionResult GetCallersByShow(int id)
        {
            var item = Repository.GetCallersByShow(id);
            if (!item.Any()) return HttpNotFound();
            return new ObjectResult(item);
        }

        //--------------------------- POST ---------------------

        // POST api/values
        [HttpPost("addshow")]
        public IActionResult AddShow([FromBody] Show show)
        {
            if (show == null) return HttpBadRequest();
            Repository.AddShow(show);
            return CreatedAtRoute("GetShow", new {controller = "Nettles", id=show.Id}, show);
        }

        //--------------------------- PUT ---------------------

        [HttpPut("updateshow/{id}")]
        public IActionResult UpdateShow(int id, [FromBody] Show show)
        {
            if (show == null || show.Id != id) return HttpBadRequest();
            if (!Repository.GetShow(id).Any()) return HttpNotFound();
            Repository.UpdateShow(show);
            return new NoContentResult();
        }

        //--------------------------- DELETE ---------------------


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
