using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class HelpManager
    {
        public static bool CheckIfSensorExits(IAgent agent, string sensorName)
        {
            foreach (string sensor in agent.sensorsDict.Keys)
            {
                if (sensorName == sensor)
                {
                    return true;
                }
            }return false;
        }
    }
}
