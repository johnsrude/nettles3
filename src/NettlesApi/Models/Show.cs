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
        public int ShowId;
        public DateTime Time;
        public string Title;
        public Address Address;
        public string Note;
        public string Url;
        public IEnumerable<string> Callers;
    }
}
