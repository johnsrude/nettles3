using System;
using System.Collections.Generic;

namespace NettlesApi.Models
{
    public class Show
    {
        public int Id { get; set; }
        public DateTime Time { get; set; } // Local time to venue. No need for UTC
        public string Title { get; set; }
        public Venue Venue { get; set; }
        public string Note { get; set; }
        public string Url { get; set; }
        public Image Image { get; set; }
        public List<Caller> Callers { get; set; }
    }
}
