using FSPApi.Access;
using FSPApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost][Route("regathlete")]
        public IActionResult PostReg(Athlete athlete)
        {
            try
            {
                using FSPContext db = new();
                db.Athletes.Add(new Athlete { Login = athlete.Login, Password = athlete.Password });
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost][Route("authathlete")]
        public IActionResult PostAuth(Athlete athlet)
        {
            try
            {
                using FSPContext db = new();
                var athlete = db.Athletes.FirstOrDefault(x => x.Login == athlet.Login && x.Password == athlet.Password);
                if (athlete is not null)
                    return Ok(athlete.Id);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost][Route("regteam")]
        public IActionResult PostTeam(Team team)
        {
            try
            {
                using FSPContext db = new();
                db.Teams.Add(team);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost][Route("regcoach")]
        public IActionResult PostRegCoach(Coach coach)
        {
            try
            {
                using FSPContext db = new();
                db.Coachs.Add(coach);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost][Route("authcoach")]
        public IActionResult PostAuthCoach(Coach coach)
        {
            try
            {
                using FSPContext db = new();
                var coac = db.Athletes.FirstOrDefault(x => x.Login == coach.Login && x.Password == coach.Password);
                if (coac is not null)
                    return Ok(coac.Id);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
