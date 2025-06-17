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
            Console.WriteLine("enter a number");
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
    }
}
