﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travnik_backend.Models;

namespace travnik_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccomodationTypesController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public AccomodationTypesController(AppDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        //GET: api/AccomodationTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccomodationType>>> GetAccomodationTypes()
        {
            if (_dbContext.AccomodationTypes == null)
                return NotFound();

            return await _dbContext.AccomodationTypes.ToListAsync();
        }

        //GET: api/AccomodationTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AccomodationType>> GetAccomodation(int id)
        {
            if (_dbContext.AccomodationTypes == null)
                return NotFound();

            var at =await _dbContext.AccomodationTypes.FindAsync(id);

            if (at == null)
                return NotFound();

            return at;
        }
    }
}