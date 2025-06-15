using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal interface IAgent
    {
        string name { get; set; }

        Dictionary<string, bool> sensor { get; set; }

    }
}
