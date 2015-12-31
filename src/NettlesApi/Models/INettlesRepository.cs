using System.Collections.Generic;
using System.Linq;

namespace NettlesApi.Models
{
    public interface INettlesRepository
    {
        void AddShow(Show show);
        List<Show> GetAllShows();
        IQueryable<Show> GetShow(string key);
        IQueryable<Caller> GetCallersByShow(string key);
        Show DeleteShow(string key);
        void UpdateShow(Show show);
    }
}
