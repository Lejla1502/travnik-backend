using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travnik_backend.Models;

namespace travnik_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccomodationsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public AccomodationsController(AppDbContext dbContext)
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

            //even though there is accomodation with a given id, it still won't recognize it if it doen't have
            //type id declared and it will return 404
            var a = await _dbContext.Accomodations.Include(x => x.AccomodationType).Where(y => y.Id == id).FirstOrDefaultAsync();
            //we nned to use firsOrDefualt so that it doesn't throw an error if it doesn't find an element

            if (a == null)
                return NotFound();

            return a;
        }
    }
}
