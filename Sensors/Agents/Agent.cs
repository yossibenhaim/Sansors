using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class Agent
    {
        public string name { get; }

        public Dictionary<string, int> weaknessesSensorsDict { get; private set; } = new Dictionary<string, int>();

        public List<ISensor> attachedSensors { get; private set; } = new List<ISensor>(); 
        public Agent(string name, ISensor[] sensors) 
        {
            this.name = name;
            foreach(ISensor sensor in sensors)
            {
                if (weaknessesSensorsDict.ContainsKey(sensor.name))
                { weaknessesSensorsDict[sensor.name] += 1; }
                else
                { weaknessesSensorsDict[sensor.name] = 1; }
            }
        }

        public void AttachingSensors(ISensor newSensor)
        {
            attachedSensors.Add(newSensor);
        }
    }
}
