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

            Manager manager = new Manager();
            manager.CreatRoom();
            manager.CreatRoom();
            manager.PrintDict(manager.rooms[0]);
            manager.PrintDict(manager.rooms[1]);





        }
    }
}