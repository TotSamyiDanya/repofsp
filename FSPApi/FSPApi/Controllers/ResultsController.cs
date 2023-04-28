using FSPApi.Access;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        [HttpGet][Route("list")]
        public IActionResult GetResults(Guid id)
        {
            try
            {
                using FSPContext db = new();
                return Ok(db.Results.Where(x => x.Event.Id == id).ToArray());
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
