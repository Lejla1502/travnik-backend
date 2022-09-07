using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travnik_backend.Models;

namespace travnik_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public AttractionsController(AppDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        //GET: api/Attractions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attraction>>> GetAttractions()
        {
            if (_dbContext.Attractions == null)
                return NotFound();

            return await _dbContext.Attractions.ToListAsync();

        }

        //GET: api/Attractions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Attraction>> GetAttraction(int id)
        {
            if (_dbContext.Attractions == null)
                return NotFound();

            var atr = await _dbContext.Attractions.FindAsync(id);

            if (atr == null)
                return NotFound();

            return atr;
        }
    }
}
