using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using travnik_backend.Models;

namespace travnik_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizerController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public OrganizerController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }




    }
}
