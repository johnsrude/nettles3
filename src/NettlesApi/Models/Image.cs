﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NettlesApi.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public byte[] Picture { get; set; }
    }
}
