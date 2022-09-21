using Microsoft.EntityFrameworkCore;
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
        public DbSet<Room> Rooms { get; set; } = null!;
        public DbSet<Listing> Listings { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Accomodation.Accomodation>()
               .HasOne(ac=>ac.AccomodationType)
               .WithMany(g => g.Accomodations)
               .HasForeignKey(ac => ac.AccomodationTypeId);
        }
    }

}
