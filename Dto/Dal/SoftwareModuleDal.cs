﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Dal
{
    public class SoftwareModuleDal : BaseDal
    {
        public string SoftwareModuleName { get; set; }
        public SoftwareDal Software { get; set; }
    }
}
