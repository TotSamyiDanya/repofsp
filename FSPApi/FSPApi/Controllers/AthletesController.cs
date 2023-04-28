using FSPApi.Access;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AthletesController : ControllerBase
    {
        [HttpGet][Route("athlete")]
        public IActionResult GetAthlete(Guid id)
        {
            try
            {
                using FSPContext db = new();
                return Ok(db.Athletes.Where(x => x.Id == id).FirstOrDefault());
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet][Route("list")]
        public IActionResult GetAthletes()
        {
            try
            {
                using FSPContext db = new();
                return Ok(db.Athletes.ToArray());
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet][Route("team")]
        public IActionResult GetAthletesTeam(Guid id)
        {
            try
            {
                using FSPContext db = new();
                return Ok(db.Teams.Where(x => x.Id == id).Select(x => x.Athletes).ToArray());
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
