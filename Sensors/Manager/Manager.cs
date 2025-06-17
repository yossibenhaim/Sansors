using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class Manager
    {
        public List<IAgent> rooms = new List<IAgent>();



        public void AddedSensorToAgent(IAgent agent, ISensor sensor)
        {

            agent.attachedSensors.Add(sensor);
        }
        public void PrintDict(IAgent agent)
        {
            foreach (string key in agent.weaknessesSensorsDict.Keys)
            {
                Console.WriteLine(key);
                Console.WriteLine(agent.weaknessesSensorsDict[key]);
            }
        }

        public int[] FindingTheCorrectNumberOfSensorsAttached(IAgent agent)
        {
            int countSensorsAttached = 0;
            int countSensorWeaknesses = HelpManager.CountingTheNumberOfWeaknessesInAnAgent(agent);
            Dictionary<string, int> ListWeaknesses = new Dictionary<string, int>(agent.weaknessesSensorsDict);

            foreach (ISensor sensor in agent.attachedSensors)
            {
                if (sensor.active)
                {
                    if (HelpManager.CheckIfSensorExits(agent, sensor.name))
                    {
                        if (agent.weaknessesSensorsDict[sensor.name] > 0)
                        {
                            countSensorsAttached ++;
                            agent.weaknessesSensorsDict[sensor.name] --;
                        }
                    }
                }
            } 

            return new int[] { countSensorsAttached, countSensorWeaknesses };
        }

    

    }
}
