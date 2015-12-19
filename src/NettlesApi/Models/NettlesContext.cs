using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace NettlesApi.Models
{
    public class NettlesContext : DbContext, INettlesRepository
    {
        public DbSet<Show> Shows { get; set; }

        public void AddShow(Show show)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Show> GetAllShows()
        {
            throw new NotImplementedException();
        }

        public Show GetShow(string key)
        {
            throw new NotImplementedException();
        }

        public Show DeleteShow(string key)
        {
            throw new NotImplementedException();
        }

        public void UpdateShow(Show show)
        {
            throw new NotImplementedException();
        }
    }
}
