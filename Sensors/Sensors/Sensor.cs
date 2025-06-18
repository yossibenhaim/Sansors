using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class Sensor : ISensor
    {
        public string sensorName { get; protected set; }

        public bool active { get; set; } = false;

        public string pinnedTo;

        public virtual void SetActive()
        {
            active = true;
        }
    }
}
