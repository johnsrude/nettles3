using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NettlesApi.Models
{
    public class Caller
    {
        public int CallerId { get; set; }
        public string FullName { get; set; }
        public string Url { get; set; }
    }
}
