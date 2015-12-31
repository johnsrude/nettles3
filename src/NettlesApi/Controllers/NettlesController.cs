using System.Collections.Generic;
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
            NettlesItems = repository;
        }

        [FromServices]
        public INettlesRepository NettlesItems { get; set; }

        // GET: api/values
        [HttpGet("shows")]
        public List<Show> Get()
        {
           return NettlesItems.GetAllShows();
        }

        [HttpGet("show/{id}")]
        public IActionResult GetShowById(string id)
        {
            var item = NettlesItems.GetShow(id);
            if (item == null) return HttpNotFound();
            return new ObjectResult(item);
        }

        [HttpGet("show/{id}/callers")]
        public IActionResult GetCallersByShow(string id)
        {
            var item = NettlesItems.GetShow(id);
            if (item == null) return HttpNotFound();
            return new ObjectResult(item);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
