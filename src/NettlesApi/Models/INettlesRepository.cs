using System.Collections.Generic;

namespace NettlesApi.Models
{
    public interface INettlesRepository
    {
        void AddShow(Show show);
        List<Show> GetAllShows();
        Show GetShow(string key);
        Show DeleteShow(string key);
        void UpdateShow(Show show);
    }
}
