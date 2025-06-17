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
            if (HelpManager.CheckIfSensorExits(agent, sensor.name))
            {
                sensor.active = true;
            }
        }
        public void PrintSensorOfAgent(IAgent agent)
        {
            Console.WriteLine("weaknessesSensorsDict");
            foreach (string key in agent.weaknessesSensorsDict.Keys)
            {
                Console.WriteLine("key " + key);
                Console.WriteLine("value of " + key + "= " + agent.weaknessesSensorsDict[key]);
            }
            Console.WriteLine("attachedSensors");
            foreach (ISensor sensor in agent.attachedSensors)
            {
                Console.WriteLine("name of sensor = " + sensor.name);
                Console.WriteLine("sensor active = " + sensor.active);
            }

        }

        public int FindingTheNumberOfCorrectSensorsConnected(IAgent agent)
        {
            int countSensorsAttached = 0;
            Dictionary<string, int> DictWeaknesses = new Dictionary<string, int>(agent.weaknessesSensorsDict);

            foreach (ISensor sensor in agent.attachedSensors)
            {
                if (sensor.active)
                {
                    if (HelpManager.CheckIfSensorExits(agent, sensor.name))
                    {
                        if (agent.weaknessesSensorsDict[sensor.name] > 0)
                        {
                            countSensorsAttached ++;
                            DictWeaknesses[sensor.name] --;
                        }
                    }
                }
            }
            return countSensorsAttached;
            
        }
        public bool CheckingIfTheGameComplete(IAgent agent)
        {
            if (FindingTheNumberOfCorrectSensorsConnected(agent) == HelpManager.CountingTheNumberOfWeaknessesInAnAgent(agent))
            {
                return false;
            }
            return true; 
        }


    }
}
