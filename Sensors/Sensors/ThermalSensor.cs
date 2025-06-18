using Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class ThermalSensor : Sensor, ISensor
    {
        public ThermalSensor(string name)
        {
            this.sensorName = name;
        }
    }
}
