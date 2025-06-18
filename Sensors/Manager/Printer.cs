using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal static class Printer
    {
        public static void PrintStartMenu()
        {
            Console.WriteLine("To select Audio Sensor select 1\r\nTo select Thermal Sensor select 2\r\nTo select Sensor Plus select 3\r\nTo exit select 4");
        }

        public static void PrintCountOfCorrectSensor(int countSensor)
        {
            Console.WriteLine("The count of correct sensor is " + countSensor);
        }
        public static void PrintCountOfWeaknesses(int countSensorWeaknesses)
        {
            Console.WriteLine("The count of Weaknesses in agent is " + countSensorWeaknesses);
        }
        public static void PrintCompleteGame()
        {
            Console.WriteLine("Well done!!");
            Console.WriteLine("You have completed the game!!");
        }
        public static void PrintAllAttachingSensors(IAgent agent)
        {
            Console.WriteLine("the attached sensors is:");
            for (int i = 0; i < agent.attachedSensors.Length; i ++)
            {
                if (agent.attachedSensors[i] != null && agent.attachedSensors[i].sensorName != null)
                {
                    Console.WriteLine($"the sensor : {agent.attachedSensors[i].sensorName} is found in index {i}");
                }
                else
                {
                    Console.WriteLine($"indem {i} is empty");
                }
            }
            Console.WriteLine();
        }
    }
}
