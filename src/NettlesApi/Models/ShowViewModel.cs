using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NettlesLibrary.ViewModels
{
    public class ShowViewModel
    {
        // Show
        public DateTime Time { get; set; } // Local time to venue. No need for UTC
        public string Title { get; set; }
        public string Note { get; set; }
        public string Url { get; set; }

        // Image 
        public byte[] Picture { get; set; }

        // Venue
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string StreetAddress { get; set; }
        public string Phone { get; set; }
        public string VenueUrl { get; set; }

        // Caller 
        // TODO: Allow up to 3  callers.  Need to change AutoMap.
        public string FullName { get; set; }
        public string CallerUrl { get; set; }
    }
}
