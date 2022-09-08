using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travnik_backend.Models;

namespace travnik_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public FeaturesController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET: api/Features
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Features>>> GetFeatures()
        {
            if (_dbContext.Features == null)
                return NotFound();

            return await _dbContext.Features.ToListAsync();
        }

        //GET: api/Features/1
        [HttpGet("{id}")]
        [ActionName(nameof(Features))]
        public async Task<ActionResult<Features>> GetFeature(int id)
        {
            if (_dbContext.Features == null)
                return NotFound();

            var f = await _dbContext.Features.FindAsync(id);

            if (f == null)
                return NotFound();

            return f;
        }

        //POST: api/Feature
        [HttpPost]
        public async Task<ActionResult<Features>> PostFeature(Features feature)
        {
            _dbContext.Features.Add(feature);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Features), new { id = feature.Id }, feature);
        }
    }
}
