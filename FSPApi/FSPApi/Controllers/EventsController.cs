using FSPApi.Access;
using FSPApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        [HttpGet][Route("event")]
        public IActionResult GetEvent(Guid id)
        {
            try
            {
                using FSPContext db = new();
                return Ok(db.Events.Where(x => x.Id == id).FirstOrDefault());
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet][Route("list")]
        public IActionResult GetEvents()
        {
            try
            {
                using FSPContext db = new();
                return Ok(db.Events.ToArray());
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpPost][Route("addeve")]
        public IActionResult AddEvent(Event eve)
        {
            try
            {
                using FSPContext db = new();
                db.Add(eve);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
