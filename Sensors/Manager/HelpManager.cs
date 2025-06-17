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
            foreach (string sensor in agent.weaknessesSensorsDict.Keys)
            {
                if (sensorName == sensor)
                {
                    return true;
                }
            }return false;
        }
        public static int CountingTheNumberOfSensorsAttachedAgent(IAgent agent)
        {
            int countSensorsAttached = 0;
            foreach (ISensor sensor in agent.attachedSensors)
            {
                if (sensor.active)
                {
                    countSensorsAttached++;
                }
            }
            return countSensorsAttached;
        }
        public static int CountingTheNumberOfWeaknessesInAnAgent(IAgent agent)
        {
            int countSensorWeaknesses = 0;
            foreach (int countSensor in agent.weaknessesSensorsDict.Values)
            {
                countSensorWeaknesses++;
            }
            return countSensorWeaknesses;
        }
    }
}
