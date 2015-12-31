using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace NettlesApi.Models
{
    public class Show
    {
        public int Id { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public string Title { get; set; }
        
        public Venue Venue { get; set; }
        public string Note { get; set; }
        public string Url { get; set; }
        public Image Image { get; set; }
        public List<Caller> Callers { get; set; }
    }
}
