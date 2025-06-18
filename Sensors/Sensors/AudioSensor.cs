using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class AudioSensor : Sensor, ISensor
    {
        public AudioSensor(string name)
        {
            sensorName = name;
        }
       
    }
}