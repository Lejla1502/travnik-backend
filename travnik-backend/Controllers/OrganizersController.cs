using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travnik_backend.Models;

namespace travnik_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizersController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public OrganizersController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET: api/Organizer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organizer>>> GetEvents()
        {
            if (_dbContext.Organizers == null)
                return NotFound();

            return await _dbContext.Organizers.ToListAsync();
        }

        //GET: api/Organizer/5
        [HttpGet("{id}")]
        [ActionName(nameof(Organizer))]
        public async Task<ActionResult<Organizer>> GetOrganizer(int id)
        {
            if (_dbContext.Organizers == null)
            {
                return NotFound();
            }

            var e = await _dbContext.Organizers.FindAsync(id);

            if (e == null)
                return NotFound();

            return e;
        }


    }
}
