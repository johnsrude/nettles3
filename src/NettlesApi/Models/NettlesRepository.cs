using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using NettlesApi.Models;

namespace NettlesApi.Models
{
    public class NettlesRepository : INettlesRepository
    {
        private NettlesContext _db;

        public NettlesRepository(NettlesContext context)
        {
            _db = context;
        }

        public void AddShow(Show show)
        {
            throw new NotImplementedException();
        }

        public List<Show> GetAllShows()
        {
            return _db.Shows.ToList();
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
