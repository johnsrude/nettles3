using System;
using System.Collections.Generic;
using System.Linq;

namespace NettlesApi.Models
{
    public class NettlesRepository : INettlesRepository
    {
        private readonly NettlesContext _db;

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

        public IQueryable<Show> GetShow(string key)
        {
            int showId;
            return !int.TryParse(key, out showId) ? null : _db.Shows.Where(show => show.Id == showId);
        }

        public IQueryable<Caller> GetCallersByShow(string key)
        {
            return GetShow(key)?.FirstOrDefault()?.Callers.AsQueryable();
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
