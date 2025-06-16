using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class Manager
    {
        public List<ISensor> sensors = new List<ISensor>();

        public void AddedSensorToAgent(IAgent agent, string sensorName)
        {
            if (HelpManager.CheckIfSensorExits(agent, sensorName))
            {
                agent.sensorsDict[sensorName]--;
            }
        }
        public void CreatShowOfSensor()
        {
        }
    }
}
