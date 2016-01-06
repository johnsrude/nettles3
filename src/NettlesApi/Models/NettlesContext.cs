using Microsoft.Data.Entity;

namespace NettlesApi.Models
{ 
    public class NettlesContext : DbContext
    {
        public DbSet<Show> Shows { get; set; }
        public DbSet<Venue> Venues { get; set; } 
        public DbSet<Image> Images { get; set; }
        public DbSet<Caller> Callers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            new ShowConfiguration(builder.Entity<Show>());
            new CallerConfiguration(builder.Entity<Caller>());
            new ImageConfiguration(builder.Entity<Image>());
        }
    }
}
