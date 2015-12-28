using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace NettlesApi.Models
{
    public class NettlesContext : DbContext
    {
        public DbSet<Show> Shows { get; set; }
        public DbSet<Venue> Venues { get; set; } 
        public DbSet<Image> Images { get; set; }
    }
}
