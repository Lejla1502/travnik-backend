using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travnik_backend.Models;

namespace travnik_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ActivitiesController(AppDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        //GET: api/Activities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Activities>>> GetActivities()
        {
            if (_dbContext == null)
                return NotFound();

            return await _dbContext.Activities.ToListAsync();
        }

        //GET: api/Activities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Activities>> GetActivity(int id)
        {
            if (_dbContext == null)
                return NotFound();

            var act = await _dbContext.Activities.FindAsync(id);

            if (act == null)
                return NotFound();

            return act;
        }
    }
}
