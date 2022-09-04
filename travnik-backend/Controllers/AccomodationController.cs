using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travnik_backend.Models;

namespace travnik_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccomodationController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public AccomodationController(AppDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        //GET: api/Accomodations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Accomodation>>> GetAccomodations()
        {
            if (_dbContext.Accomodations == null)
                return NotFound();

            return await _dbContext.Accomodations.Include(x=>x.AccomodationType).ToListAsync();
        }

        //GET: api/Accomodations/5
        [HttpGet("{id}")]
        [ActionName(nameof(Accomodation))]
        public async Task<ActionResult<Accomodation>> GetAccomodation(int id)
        {
            if (_dbContext.Accomodations == null)
                return NotFound();

            var a = await _dbContext.Accomodations.Include(x => x.AccomodationType).Where(y => y.Id == id).FirstAsync();

            if (a == null)
                return NotFound();

            return a;
        }
    }
}
