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



        public void AddedSensorToAgent(IAgent agent, string sensorName)
        {
            if (HelpManager.CheckIfSensorExits(agent, sensorName))
            {
                agent.weaknessesSensorsDict[sensorName]--;
            }
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

        //public void Creat()
        //{
        //    AudioSensor audio = new AudioSensor("room1");
        //    ThermalSensor thermal = new ThermalSensor("room1");
        //    List<ISensor> sensors = new List<ISensor>();
        //    sensors.Add(audio);
        //    sensors.Add(thermal);
        //    FootAgent agent = new FootAgent("chaim", sensors.ToArray());

        //    this.rooms.Add(agent);
        //}

    }
}
