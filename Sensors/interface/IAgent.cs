

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal interface IAgent
    {
        string name { get; }

        Dictionary<string,int> weaknessesSensorsDict { get; } // שם החולשה

        List<ISensor> attachedSensors { get; }
    }
}
