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
        public async Task<ActionResult<IEnumerable<TopLevelFeatures>>> GetFeatures()
        {
            if (_dbContext.TopLevelFeatures == null)
                return NotFound();

            return await _dbContext.TopLevelFeatures.ToListAsync();
        }

        //GET: api/Features/1
        [HttpGet("{id}")]
        [ActionName(nameof(TopLevelFeatures))]
        public async Task<ActionResult<TopLevelFeatures>> GetFeature(int id)
        {
            if (_dbContext.TopLevelFeatures == null)
                return NotFound();

            var f = await _dbContext.TopLevelFeatures.FindAsync(id);

            if (f == null)
                return NotFound();

            return f;
        }

        //POST: api/Feature
        [HttpPost]
        public async Task<ActionResult<TopLevelFeatures>> PostFeature(TopLevelFeatures feature)
        {
            _dbContext.TopLevelFeatures.Add(feature);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(TopLevelFeatures), new { id = feature.Id }, feature);
        }
    }
}
