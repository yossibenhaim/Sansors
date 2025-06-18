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

        public List<ISensor> removeSensors = new List<ISensor>();

        public void AddedSensorToAgent(IAgent agent, ISensor sensor)
        {
            agent.attachedSensors.Add(sensor);
            sensor.pinnedTo = agent;
        }

        public void ActiveActivation(ISensor sensor)
        {
            sensor.StartActive();
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

        public bool CheckingIfTheSensorIsWorkingProperly(IAgent agent,string sensorName)
        {
            Dictionary<string, int> dictWeaknesses = new Dictionary<string, int>(agent.weaknessesSensorsDict);

            Dictionary<string, int> attachedSensors = HelpManager.CreatingDictionaryFromAttachedSensors(agent);

            try
            {
                if (dictWeaknesses[sensorName] == attachedSensors[sensorName])
                    {
                        return true;
                    }
                return false;
            }
            catch
            {
                return false;
            }
                     
        }
        public bool CheckingIfTheGameComplete(IAgent agent)
        {
            if (FindingTheNumberOfCorrectSensorsConnected(agent) == FindingTheNumberOfWeaknesses(agent))
            {
                foreach (ISensor sensor in agent.attachedSensors)
                {
                    if (CheckingIfTheSensorIsWorkingProperly(agent,sensor.sensorName))
                    {
            
                        Printer.PrintCompleteGame();
                        return false;
                    }
                }
            }
            return true;
        }
        public int FindingTheNumberOfCorrectSensorsConnected(IAgent agent)
        {
            int countCorrectSensor = 0;
            foreach (ISensor sensor in agent.attachedSensors)
            {
                if (sensor.active)
                {
                    countCorrectSensor++;
                }
            }
            return countCorrectSensor;
        }
        public int FindingTheNumberOfWeaknesses(IAgent agent)
        {
            int countWeaknesses = 0;
            foreach (int countOfSensor in agent.weaknessesSensorsDict.Values)
            {
                countWeaknesses += countOfSensor;   
            }
            return countWeaknesses;
        }

        public static void RemovingClippedSensor(ISensor sensor, IAgent agent)
        {
            foreach (string key in agent.weaknessesSensorsDict.Keys)
            {
                if (key == sensor.sensorName)
                {
                    agent.attachedSensors.Remove(sensor);
                    return;
                }
            }
        }

    }
}
