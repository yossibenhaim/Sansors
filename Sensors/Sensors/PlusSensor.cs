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
            {
                this.breakSensor();
            }
        }
        private void breakSensor()
        {
            if (this.countActive >= 3)
            {
                Manager.RemovingClippedSensor(this, pinnedTo);
            }
        }
    }
}
