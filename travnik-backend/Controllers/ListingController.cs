using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travnik_backend.Models;

namespace travnik_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ListingController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Listing>>> GetListings()
        {
            if (_dbContext.Listings == null)
                return NotFound();

            return await _dbContext.Listings.ToListAsync();
        }
    }
}
