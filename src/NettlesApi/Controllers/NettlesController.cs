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
        public NettlesController(INettlesRepository db)
        {
            Db = db;
        }

        [FromServices]
        public INettlesRepository Db { get; set; }

        //--------------------------- GET ---------------------

        [HttpGet("shows")]
        public IActionResult GetShows()
        {
            var item = Db.GetShows();
            if (!item.Any()) return HttpNotFound();
            return new ObjectResult(item);
        }

        [HttpGet("show/{id}", Name = "GetShow")]
        public IActionResult GetShow(int id)
        {
            var item = Db.GetShow(id);
            if (!item.Any()) return HttpNotFound();
            return new ObjectResult(item);
        }

        [HttpGet("callers")]
        public IActionResult GetCallers()
        {
            var item = Db.GetCallers();
            if (!item.Any()) return HttpNotFound();
            return new ObjectResult(item);
        }

        [HttpGet("show/{id}/callers")]
        public IActionResult GetCallersByShow(int id)
        {
            var item = Db.GetCallersByShow(id);
            if (!item.Any()) return HttpNotFound();
            return new ObjectResult(item);
        }

        //--------------------------- POST ---------------------

        [HttpPost("addshow")]
        public IActionResult AddShow([FromBody] Show show)
        {
            if (show == null) return HttpBadRequest();
            Db.AddShow(show);
            return CreatedAtRoute("GetShow", new {controller = "Nettles", id=show.Id}, show);
        }

        //--------------------------- PUT ---------------------

        [HttpPut("updateshow/{id}")]
        public IActionResult UpdateShow(int id, [FromBody] Show show)
        {
            if (show == null || show.Id != id) return HttpBadRequest();
            if (!Db.GetShow(id).Any()) return HttpNotFound();
            Db.UpdateShow(show);
            return new NoContentResult();
        }

        //--------------------------- DELETE ---------------------


        [HttpDelete("deleteshow/{id}")]
        public void DeleteShow(int id)
        {
            Db.DeleteShow(id);
            // "void" returns an HTTP 204 (no content) response
        }
    }
}
