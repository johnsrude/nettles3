using System.Collections.Generic;
using System.Linq;

namespace NettlesApi.Models
{
    public interface INettlesRepository
    {
        void AddShow(Show show);
        IEnumerable<Show> GetShows();
        IQueryable<Show> GetShow(int id);
        IQueryable<Caller> GetCallersByShow(int id);
        void DeleteShow(int id);
        void UpdateShow(Show show);
        IEnumerable<Caller> GetCallers();
        IQueryable<Show> GetNextShow();
        IEnumerable<Show> GetNextShows();
    }
}
