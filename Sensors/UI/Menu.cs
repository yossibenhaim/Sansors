
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class Menu
    {
        public void StartNemu()
        {
            bool run = true;
            while (run)
            {
                Printer.PrintStartMenu();
          
                string cohice = Console.ReadLine();

                switch (cohice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                }
            }
        }
    }
}
