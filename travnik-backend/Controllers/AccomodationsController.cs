using BenchmarkDotNet.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using travnik_backend.Models;
using travnik_backend.Models.Accomodation;

namespace travnik_backend.Controllers
{
    [MemoryDiagnoser]
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
        //[Benchmark]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Accomodation>>> GetAccomodations()
        {
            if (_dbContext.Accomodations == null)
                return NotFound();

            return await _dbContext.Accomodations.Include(x => x.AccomodationType).ToListAsync();
                //.Include(x=>x.Features).ToListAsync();
        }

        //GET: api/Accomodations/5
        [Benchmark]
        [Arguments(4)]
        [HttpGet("{id}")]
        [ActionName(nameof(Accomodation))]
        public async Task<ActionResult<Accomodation>> GetAccomodation(int id)
        {
            if (_dbContext.Accomodations == null)
                return NotFound();

            //even though there is accomodation with a given id, it still won't recognize it if it doen't have
            //type id declared and it will return 404

            //var a = await _dbContext.Accomodations.Where(y => y.Id == id)
            //    .Include(x => x.AccomodationType)
            //    .Include(x => x.AccomodationRoomNames)
            //    .ThenInclude(x => x.RoomName)
            //    .ThenInclude(x => x.AccomodationRoomNames)
            //    .ThenInclude(x => x.AccomodationRoomNameBeds)
            //    .ThenInclude(x => x.Bed)
            //    .Include(x => x.AccomodationRoomNames)
            //    .ThenInclude(x => x.RoomFeatures).FirstOrDefaultAsync();

            var a = await _dbContext.Accomodations.Where(x => x.Id == id).AsNoTracking()
            .Include(x => x.AccomodationType)
                .Include(x => x.AccomodationRoomNames)
                .ThenInclude(x => x.RoomName)
                .ThenInclude(x => x.RoomNameDetails)
                .ThenInclude(x => x.RoomsInRooms)
                .ThenInclude(x => x.RoomsInRoomBeds)
                .ThenInclude(x => x.Bed)
                .Include(x => x.AccomodationRoomNames)
                .ThenInclude(x => x.AccomodationRoomNameBeds)
                .ThenInclude(x => x.Bed)
                .Include(x => x.AccomodationRoomNames)
                .ThenInclude(x => x.RoomFeatures)
                .Include(x=>x.AccomodationRoomNames).ThenInclude(x=>x.TopLevelFeatures)
                //.Select(z => new
                //{
                //    z.AccomodationRoomNames.Select(w => new
                //    {
                //        w.
                //    })
                //    //Id = id,
                //    //Name = x.Name,
                //    //Description = x.Description,
                //    //Email = x.Email,
                //    //Address = "jgfgfdjgd",
                //    //Website = "kjgkdfjg",
                //    //Phone = x.PhoneNumber
                //})
                .AsNoTracking().AsSplitQuery().FirstOrDefaultAsync();

            // var a = await _dbContext.Accomodations.Where(x => x.Id == id).FirstOrDefaultAsync();
            //.Include(x => x.AccomodationType)
            //    .Include(x => x.AccomodationRoomNames)
            //    .ThenInclude(x => x.RoomName)
            //    .ThenInclude(x => x.RoomNameDetails)
            //    .ThenInclude(x => x.RoomsInRooms)
            //    .ThenInclude(x => x.RoomsInRoomBeds)
            //    .ThenInclude(x => x.Bed)
            //    .Include(x => x.AccomodationRoomNames)
            //    .ThenInclude(x => x.AccomodationRoomNameBeds)
            //    .ThenInclude(x => x.Bed)
            //    .Include(x => x.AccomodationRoomNames)
            //    .ThenInclude(x => x.RoomFeatures)
            //    .ToList()
            //    .Select(x => new GetSingleAccomodationDTO
            //    {
            //        Id = id,
            //        Name = x.Name,
            //        Description = x.Description,
            //        Email = x.Email,
            //        Address = "jgfgfdjgd",
            //        Website = "kjgkdfjg",
            //        Phone = x.PhoneNumber
            //    }).Where(x => x.Id == id).FirstOrDefault();

            // var b=a.Include(x=>x.AccomodationRoomNameBeds).ThenInclude(x=>x.Bed).FirstOrDefaultAsync();

            //we nned to use firsOrDefualt so that it doesn't throw an error if it doesn't find an element

            //var fg = a.AccomodationRoomNames.Select(
            //   s => new
            //   {
            //       s.RoomName.Name,
            //       BR = s.RoomName.AccomodationRoomNames.FirstOrDefault().AccomodationRoomNameBeds.ToList().Select(arnb =>
            //       {
            //           arnb.NumOfBedsOfThisType,
            //            arnb.Bed.Name

            //       })
            //   });

            if (a == null)
                return NotFound();


            return a;
        }
    }
}
