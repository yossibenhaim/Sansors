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
        public void CreatRoom()
        {
            AudioSensor audio = new AudioSensor("room1");
            ThermalSensor thermal = new ThermalSensor("room1");
            List<ISensor> sensors = new List<ISensor>();
            sensors.Add(audio);
            sensors.Add(thermal);
            FootAgent agent = new FootAgent("chaim", sensors.ToArray());

            this.rooms.Add(agent);
        }

    }
}
