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
    }
}
