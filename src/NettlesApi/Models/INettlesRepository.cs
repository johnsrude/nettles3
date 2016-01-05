using System.Collections.Generic;
using System.Linq;

namespace NettlesApi.Models
{
    public interface INettlesRepository
    {
        void AddShow(Show show);
        IEnumerable<Show> GetShows();
        IQueryable<Show> GetShow(string key);
        IQueryable<Caller> GetCallersByShow(string key);
        Show DeleteShow(string key);
        void UpdateShow(Show show);
        IEnumerable<Caller> GetCallers();
    }
}
