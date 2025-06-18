using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class PlusSensor : Sensor,ISensor
    {
        private int _count;
        public PlusSensor(string name)
        {
            this.sensorName = name;
            this._count = 0;
        }
        public override void SetActive()
        {
            base.SetActive();   
            this._count++;
            this.breakSensor();
        }
        private void breakSensor()
        {
            if (this._count >= 3)
            {
                Manager.RemovingClippedSensor(this.sensorName, pinnedTo);
            }
        }
    }
}
