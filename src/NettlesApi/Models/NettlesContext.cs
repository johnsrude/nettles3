using Microsoft.Data.Entity;

namespace NettlesApi.Models
{
    public class NettlesContext : DbContext
    {
        public DbSet<Show> Shows { get; set; }
        public DbSet<Venue> Venues { get; set; } 
        public DbSet<Image> Images { get; set; }
        public DbSet<Caller> Callers { get; set; }
    }
}
