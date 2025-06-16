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

        public Dictionary<string, int> sensorsDict { get; private set; } = new Dictionary<string, int>();

        public Agent(string name, List<string> sensors)
        {
            this.name = name;
            foreach(string sensor in sensors)
            {
                if (sensorsDict.ContainsKey(sensor))
                { sensorsDict[sensor] += 1; }
                else
                { sensorsDict[sensor] = 1; }
            }
        }
    }
}
