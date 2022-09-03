using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travnik_backend.Models;

namespace travnik_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public EventsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET: api/Events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            if (_dbContext.Events == null)
                return NotFound();

            return await _dbContext.Events.ToListAsync();
        }

        //GET: api/Events/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            if(_dbContext.Events == null)
            {
                return NotFound();
            }

            var e = await _dbContext.Events.FindAsync(id);
            
            if(e == null)
                return NotFound();

            return e;
        }
    }
}
