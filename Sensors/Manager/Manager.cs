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
            sensor.pinnedTo = agent;
        }

        public void ActiveActivation(ISensor sensor)
        {
            sensor.Active();
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
                Console.WriteLine("name of sensor = " + sensor.sensorName);
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
                    if (HelpManager.CheckIfSensorExits(agent, sensor.sensorName))
                    {
                        if (agent.weaknessesSensorsDict[sensor.sensorName] > 0)
                        {
                            countSensorsAttached ++;
                            DictWeaknesses[sensor.sensorName] --;
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
                Printer.PrintCompleteGame();
                return false;
            }
            return true; 
        }

        public static void RemovingClippedSensor(string sensorName, IAgent agent)
        {
            foreach (string key in agent.weaknessesSensorsDict.Keys)
            {
                if (key == sensorName)
                {
                    agent.weaknessesSensorsDict[key]--;
                    return;
                }
            }
        }

    }
}
