using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class PlusSensor : Sensor,ISensor
    {
        public PlusSensor(string name)
        {
            this.sensorName = name;
            this.countActive = 0;
        }
        public override void Active()
        {
            base.Active();
            if (!this.active)
            {
                this.breakSensor();
            }
        }
        private void breakSensor()
        {
            foreach (ISensor sensor in pinnedTo.attachedSensors)
            {
                //Console.WriteLine(sensor.sensorName);
                //Console.WriteLine(this.countActive);
            }
            if (this.countActive >= 3)
            {
                Manager.RemovingClippedSensor(this, pinnedTo);
            }
        }
    }
}
