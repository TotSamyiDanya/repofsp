using FSPApi.Access;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        [HttpGet][Route("team")]
        public IActionResult GetTeam(Guid id)
        {
            try
            {
                using FSPContext db = new();
                return Ok(db.Teams.FirstOrDefault(x => x.Id == id));
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet][Route("eveteams")]
        public IActionResult GetEventTeams(Guid id)
        {
            try
            {
                using FSPContext db = new();
                return Ok(db.Athletes.GroupBy(x => x.Id).ToArray());
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet][Route("list")]
        public IActionResult GetTeams() 
        {
            try
            {
                using FSPContext db = new();
                return Ok(db.Teams.ToArray());
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
