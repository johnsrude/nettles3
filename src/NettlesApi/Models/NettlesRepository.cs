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


        public void DeleteShow(int id)
        {
            // Only works for simple records.
            //var item = new Show() {Id = id};
            //_db.Shows.Attach(item);
            //_db.Shows.Remove(item);

            var item = GetShow(id)?.FirstOrDefault();
            if (item == null) return;
            _db.Shows.Remove(item);
            _db.SaveChanges();
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
