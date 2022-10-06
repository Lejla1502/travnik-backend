﻿using Microsoft.EntityFrameworkCore;
using travnik_backend.Models.Accomodation;

namespace travnik_backend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Event.Event> Events { get; set; } = null!;
        public DbSet<Organizer> Organizers { get; set; } = null!;
        public DbSet<Models.Accomodation.Accomodation> Accomodations { get; set; } = null!;
        public DbSet<Models.AccomodationType.AccomodationType> AccomodationTypes { get; set; } = null!;
        public DbSet<Features> Features { get; set; } = null!;
        public DbSet<Attraction> Attractions { get; set; } = null!;
        public DbSet<Models.News.News> News { get; set; } = null!;
        public DbSet<Activities> Activities { get; set; } = null!;
        public DbSet<RoomType> RoomTypes { get; set; } = null!;
        public DbSet<RoomTypePackage> RoomTypePackages { get; set; } = null!;
        public DbSet<Bed> Beds { get; set; } = null!;
        public DbSet<RoomName> RoomNames { get; set; } = null!;
        public DbSet<RoomNameDetails> RoomNameDetails { get; set; } = null!;
        public DbSet<Listing> Listings { get; set; } = null!;
        public DbSet<ListingType> ListingTypes { get; set; } = null!;
        public DbSet<AccomodationRoomName> AccomodationRoomNames { get; set; } = null!;
        public DbSet<AccomodationRoomNameBed> AccomodationRoomNameBeds { get; set; } = null!;
        public DbSet<RoomFeatures> RoomFeatures { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Accomodation.Accomodation>()
               .HasOne(ac=>ac.AccomodationType)
               .WithMany(g => g.Accomodations)
               .HasForeignKey(ac => ac.AccomodationTypeId);


            modelBuilder.Entity<AccomodationRoomName>()
                .HasOne(bc => bc.Accomodation)
                .WithMany(b => b.AccomodationRoomNames)
                .HasForeignKey(bc => bc.AccomodationId);
            modelBuilder.Entity<AccomodationRoomName>()
                .HasOne(bc => bc.RoomName)
                .WithMany(c => c.AccomodationRoomNames)
                .HasForeignKey(bc => bc.RoomNameId);

            modelBuilder.Entity<AccomodationRoomNameBed>()
        .HasKey(bc => new { bc.AccomodationRoomNameId, bc.BedId });
            modelBuilder.Entity<AccomodationRoomNameBed>()
                .HasOne(bc => bc.AccomodationRoomName)
                .WithMany(b => b.AccomodationRoomNameBeds)
                .HasForeignKey(bc => bc.AccomodationRoomNameId);
            modelBuilder.Entity<AccomodationRoomNameBed>()
                .HasOne(bc => bc.Bed)
                .WithMany(c => c.AccomodationRoomNameBeds)
                .HasForeignKey(bc => bc.BedId);

            modelBuilder.Entity<RoomName>()
           .HasOne(b => b.RoomNameDetails)
           .WithOne(i => i.RoomName)
           .HasForeignKey<RoomNameDetails>(b => b.RoomNameId);

        }
    }
}
