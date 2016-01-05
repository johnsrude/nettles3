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
            _db.Shows.Add(show);
            _db.SaveChanges();
        }

        public IEnumerable<Show> GetShows()
        {
            return _db.Shows.ToList();
        }

        public IQueryable<Show> GetShow(int id)
        {
            return _db.Shows.Where(show => show.Id == id);
        }

        public IQueryable<Caller> GetCallersByShow(int id)
        {
            return GetShow(id)?.FirstOrDefault()?.Callers.AsQueryable();
        }


        public Show DeleteShow(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateShow(Show show)
        {
            _db.Shows.Update(show);
            _db.SaveChanges();
            return;
        }

        public IEnumerable<Caller> GetCallers()
        {
            return _db.Callers.ToList();
        }
    }
}
