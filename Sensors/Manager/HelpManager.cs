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
        public static int CountingTheNumberOfWeaknessesInAnAgent(IAgent agent)
        {
            Dictionary<string, int> ListWeaknesses = new Dictionary<string, int>(agent.weaknessesSensorsDict);
            int countSensorWeaknesses = 0;
            foreach (int countSensor in ListWeaknesses.Values)
            {
                countSensorWeaknesses++;
            }
            return countSensorWeaknesses;
        }
    }
}
