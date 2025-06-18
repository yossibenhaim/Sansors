using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class SquadLeader : Agent, IAgent
    {
        private int _counter;
        public Random random;
        public SquadLeader(string name, ISensor[] sensors) : base(name, sensors)
        {
            this._counter = 0;
            random = new Random();
        }
        public override void AttachingSensors(ISensor newSensor, int index)
        {
            this._counter++;
            attachedSensors[index] = newSensor;
            removeSensor();
        }
        public void removeSensor()
        {
            if (this._counter >= 3)
            {
                if (!attachedSensors.Any(s => s != null))
                {
                    return;
                }
                while (true)
                {
                    int x = random.Next(0, attachedSensors.Length);
                    if (attachedSensors[x] == null)
                    {
                        continue;
                    }
                    this.attachedSensors[x] = null;
                    this._counter = 0;
                    return;
                }
            }
        }
    }

}
