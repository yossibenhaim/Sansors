using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class Dispaly
    {
        public List<IAgent> agents = new List<IAgent>();
        public Manager manager = new Manager();
        public void FlowGame()
        {
            Creat();   
            bool run = true;
            ISensor sensorSelection;

            while (run)
            {
                sensorSelection = this.sensorSelection();
                if (sensorSelection.name == "false")
                {
                    run = false;
                }
                else
                {
                    manager.AddedSensorToAgent(agents[0],sensorSelection);
                    Printer.PrintCountOfWeaknesses(HelpManager.CountingTheNumberOfWeaknessesInAnAgent(agents[0]));
                    Printer.PrintCountOfCorrectSensor(manager.FindingTheNumberOfCorrectSensorsConnected(agents[0]));
                    run = manager.CheckingIfTheGameComplete(agents[0]);

                }
            }
        }
        public ISensor sensorSelection()
        {
            string choice;
            Console.WriteLine("enter chioce sensor");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    return new AudioSensor("AudioSensor");
                case "2":
                    return new ThermalSensor("ThermalSensor");
                case "3":
                    return new AudioSensor("false");
                default:
                    return sensorSelection();
            }
        }
        public void Creat()
        {
            AudioSensor audio = new AudioSensor("AudioSensor");
            ThermalSensor thermal = new ThermalSensor("AudioSensor");
            List<ISensor> sensors = new List<ISensor>();
            sensors.Add(audio);
            sensors.Add(thermal);
            FootAgent agent = new FootAgent("chaim", sensors.ToArray());
            agents.Add(agent); 
        }
    }
}
