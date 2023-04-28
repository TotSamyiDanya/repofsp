using FSPApi.Access;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachController : ControllerBase
    {
        [HttpGet][Route("list")]
        public IActionResult GetCoaches()
        {
            try
            {
                using FSPContext db = new();
                return Ok(db.Coachs.ToArray());
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet][Route("coach")]
        public IActionResult GetCoach(Guid id)
        {
            try
            {
                using FSPContext db = new();
                return Ok(db.Coachs.FirstOrDefault(x => x.Id == id));
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet][Route("coachteam")]
        public IActionResult GetCoachTeam(Guid id)
        {
            try
            {
                using FSPContext db = new();
                return Ok(db.Teams.Where(x => x.Id == id).Select(x => x.Coach).FirstOrDefault());
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet][Route("teamcoach")]
        public IActionResult GetTeamCoach(Guid id)
        {
            try
            {
                using FSPContext db = new();
                return Ok(db.Teams.Where(x => x.Coach.Id == id).ToArray());
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
