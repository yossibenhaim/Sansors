using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class HelpManager
    {
        public static bool CheckIfSensorExitsInDict(Dictionary<string,int> dict, string sensorName)
        {
            foreach (string sensor in dict.Keys)
            {
                if (sensorName == sensor)
                {
                    return true;
                }
            }return false;
        }

        public static Dictionary<string,int> CreatingDictionaryFromAttachedSensors(IAgent agent)
        {
            Dictionary<string, int> attachedSensors = new Dictionary<string, int>();
            foreach (ISensor sensor in agent.attachedSensors)
            {
                if (sensor.active)
                {
                    if (HelpManager.CheckIfSensorExitsInDict(attachedSensors, sensor.sensorName))
                    {
                        attachedSensors[sensor.sensorName]++;
                    }
                    else
                    {
                        attachedSensors[sensor.sensorName] = 1;
                    }
                }
            }
            return attachedSensors;

        }


        public static bool CheckingIfTheSensorIsWeak(IAgent agent, string sensorName)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>(agent.weaknessesSensorsDict);
            foreach (ISensor sensor in agent.attachedSensors)
            {
                if (sensor.active)
                {
                    dict[sensor.sensorName]--;
                }
            }
            try
            {
                return (dict[sensorName] > 0);
            }
            catch
            {
                return false;
            }
        }

        public static int CountingTheNumberOfWeaknessesInAnAgent(IAgent agent)
        {
            Dictionary<string, int> ListWeaknesses = new Dictionary<string, int>(agent.weaknessesSensorsDict);
            int countSensorWeaknesses = 0;
            foreach (int countSensor in ListWeaknesses.Values)
            {
                countSensorWeaknesses += countSensor;
            }
            return countSensorWeaknesses;
        }
    }
}
