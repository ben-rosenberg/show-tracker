#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;

namespace ShowTracker.Models
{
    public class ShowTrackerContext : DbContext
    {
        public ShowTrackerContext(DbContextOptions options) : base(options) {}

        public DbSet<Band> Bands { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<ShowsBand> ShowsBands { get; set; }
        public DbSet<User> Users { get; set; }
    }
}