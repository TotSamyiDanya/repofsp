using FSPApi.Access;
using FSPApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepresentativeController : ControllerBase
    {
        [HttpPost][Route("eventreg")]
        public IActionResult PostEvent(Event eve)
        {
            try
            {
                using FSPContext db = new();
                db.Events.Add(eve);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)             
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
