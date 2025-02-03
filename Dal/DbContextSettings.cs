using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DbContextSettings : ISettings
    {
        public bool IsEnabledSensitiveDataLogging { get; init; }
    }
}
