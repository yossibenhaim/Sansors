
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal interface ISensor
    {
        string sensorName { get; }

        bool active { get; set; }
        int countActive { get; set; }

        IAgent pinnedTo { get; set; }

        void Active();

        void StartActive();
    }
}
