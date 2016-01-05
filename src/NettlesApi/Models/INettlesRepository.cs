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
        Show DeleteShow(int id);
        void UpdateShow(Show show);
        IEnumerable<Caller> GetCallers();
    }
}
