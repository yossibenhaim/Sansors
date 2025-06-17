using Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class ThermalSensor : ISensor
    {
        public string name { get; }

        public bool active { get; set; } = false;

        public ThermalSensor(string name)
        {
            this.name = name;
        }
        public void SetActive()
        {
            active = true;
        }
    }
}
