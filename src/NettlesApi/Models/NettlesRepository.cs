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

        public IEnumerable<Show> GetShows()
        {
            var result = _db.Shows.ToList();
            return !result.Any() ? null : result;
        }

        public IQueryable<Show> GetShow(string key)
        {
            int showId;
            if (!int.TryParse(key, out showId)) return null;
            var result = _db.Shows.Where(show => show.Id == showId);
            return !result.Any() ? null : result;
        }

        public IQueryable<Caller> GetCallersByShow(string key)
        {
            var result = GetShow(key)?.FirstOrDefault()?.Callers.AsQueryable();
            return result == null || !result.Any() ? null : result;
        }


        public Show DeleteShow(string key)
        {
            throw new NotImplementedException();
        }

        public void UpdateShow(Show show)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Caller> GetCallers()
        {
            var result = _db.Callers.ToList();
            return !result.Any() ? null : result;
        }
    }
}
