using FSPApi.Access;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FSPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpPost][Route("confirmevent")]
        public IActionResult ConfirmEvent(Guid id)
        {
            try
            {
                using FSPContext db = new();
                var eve = db.Events.Where(x => x.Id == id).FirstOrDefault();
                eve.IsConfirmed = true;
                db.Update(eve);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost][Route("endevent")]
        public IActionResult EndEvent(Guid id)
        {
            try
            {
                using FSPContext db = new();
                db.Events.Where(x => x.Id == id).FirstOrDefault().IsEnd = true;
                db.Update(db.Events.Where(x => x.Id == id).FirstOrDefault().IsEnd = true);
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
