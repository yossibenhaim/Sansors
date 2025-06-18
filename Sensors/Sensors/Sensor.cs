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

        public IAgent pinnedTo { get; set; } 

        public int countActive { get; set; }

        public void StartActive()
        {
            ISensor[] copyAttachedSensors = (ISensor[])this.pinnedTo.attachedSensors.Clone();
            foreach (ISensor sensor in copyAttachedSensors)
            {
                if (sensor != null)
                {
                    sensor.Active();
                }
            }
        }
        public virtual void Active()
        {

            this.countActive++;
            
            if (HelpManager.CheckingIfTheSensorIsWeak(this.pinnedTo, this.sensorName))
            { 
                active = true;
            }
            
        }
    }
}
