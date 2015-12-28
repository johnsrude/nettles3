using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace NettlesApi.Models
{
    public class Show
    {
        public int ShowId { get; set; }
        public DateTime Time { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string Url { get; set; }
        public Venue Venue { get; set; }
        public Image Image { get; set; }
        public List<Caller> Callers { get; set; }
    }
}
