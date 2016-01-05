using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using NettlesApi.Filters;
using NettlesApi.Models;

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
            if (item == null || !item.Any()) return HttpNotFound();
            return new ObjectResult(item);
        }

        [HttpGet("show/{id}", Name = "GetShow")]
        public IActionResult GetShow(string id)
        {
            if (id == null) return HttpBadRequest();
            var item = Repository.GetShow(id);
            if (item == null) return HttpNotFound();
            return new ObjectResult(item);
        }

        [HttpGet("callers")]
        public IActionResult GetCallers()
        {
            var item = Repository.GetCallers();
            if (item == null) return HttpNotFound();
            return new ObjectResult(item);
        }

        [HttpGet("show/{id}/callers")]
        public IActionResult GetCallersByShow(string id)
        {
            if (id == null) return HttpBadRequest();
            var item = Repository.GetCallersByShow(id);
            if (item == null) return HttpNotFound();
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

    [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        //--------------------------- DELETE ---------------------


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
