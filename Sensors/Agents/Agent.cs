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

        public ISensor[] attachedSensors { get; private set; } 
        public Agent(string name, ISensor[] sensors) 
        {
            this.name = name;
            foreach(ISensor sensor in sensors)
            {
                if (weaknessesSensorsDict.ContainsKey(sensor.sensorName))
                { weaknessesSensorsDict[sensor.sensorName] += 1; }
                else
                { weaknessesSensorsDict[sensor.sensorName] = 1; }
            }
            this.attachedSensors = new ISensor[(sensors.Length)];
        }

        public void AttachingSensors(ISensor newSensor, int index)
        {
            attachedSensors[index] = newSensor;
        }
    }
}
