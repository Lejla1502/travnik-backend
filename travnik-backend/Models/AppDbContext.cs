﻿using Microsoft.EntityFrameworkCore;

namespace travnik_backend.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Models.Event.Event> Events { get; set; } = null!;
        public DbSet<Organizer> Organizers { get; set; } = null!;
        public DbSet<Accomodation> Accomodations { get; set; } = null!;
        public DbSet<AccomodationType> AccomodationTypes { get; set; } = null!;
    }
}
