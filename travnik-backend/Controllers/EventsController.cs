using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travnik_backend.Models;
using travnik_backend.Models.Event;

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

            return await _dbContext.Events.Include(x=>x.Organizer).ToListAsync();
        }

        //GET: api/Events/5
        [HttpGet("{id}")]
        [ActionName(nameof(Event))]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            if(_dbContext.Events == null)
            {
                return NotFound();
            }

            var e = await _dbContext.Events.Include(x=>x.Organizer).Where(y=>y.Id==id).FirstAsync();
            
            if(e == null)
                return NotFound();

            return e;
        }

        //POST: api/Events
        [HttpPost]
        public async Task<ActionResult<Event>> PostEvent(CreateEventDto e)
        {
            var organizer = await _dbContext.Organizers.FindAsync(e.OrganizerId);
            if (organizer == null)
                return NotFound();

            var newEvent = new Event
            {
                Title = e.Title,
                Text = e.Text,
                Location =  e.Location,
                Created = e.Created,
                DateOfEvent = e.DateOfEvent,
                Fee = e.Fee,
                Organizer = organizer
            };

            if(e.ActivityId!=null && e.ActivityId!=0)
            {
                var activity = await _dbContext.Activities.FindAsync(e.ActivityId);
                if (activity != null)
                    newEvent.Activities = activity;
            }

            _dbContext.Events.Add(newEvent);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Event), new { id = newEvent.Id }, newEvent);
        }

        /*
         PutEvent method updates the event record with the given Id in the database. 
        The following code is an HTTP PUT method, as indicated by the [HttpPut] attribute. 
        The method gets the value of the event record from the body of the HTTP request. 
        You need to supply the Id both in the request URL and the body and they have to match. 
        According to the HTTP specification, a PUT request requires the client to send the entire 
        updated entity, not just the changes.

        The response is 204 (No Content) if the operation is successful.

        Also here we use IActionResult
         */

        //PUT: api/Events/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent(int id, Event e)
        {
            if (id != e.Id)
                return BadRequest();

            _dbContext.Entry(e).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
                    return NotFound();
                else
                    throw;
            }
        

            return NoContent();
        }

        private bool EventExists(long id)
        {
            return (_dbContext.Events?.Any(x => x.Id == id)).GetValueOrDefault();
        }

        //DELETE: api/Events/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            if (_dbContext.Events == null)
                return NotFound();

            var e = _dbContext.Events.FirstOrDefault(x => x.Id == id);
            if (e == null)
                return NotFound();

            _dbContext.Events.Remove(e);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
