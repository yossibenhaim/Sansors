using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sensors = new List<string> { "AudioSensor", "ThermalSensor" };
            FootAgent agent = new FootAgent("chaim",sensors);

            Console.WriteLine(agent.name);
            foreach (string sensor in agent.sensorsDict.Keys)
            {
                Console.WriteLine(sensor);
                Console.WriteLine(agent.sensorsDict[sensor]);
            }
        }
    }
}