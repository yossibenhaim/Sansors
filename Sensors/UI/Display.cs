using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class Display
    {
        public List<IAgent> agents = new List<IAgent>();
        public Manager manager = new Manager();
        public void FlowGame()
        {
            Create();   
            bool run = true;
            ISensor sensorSelection;

            while (run)
            {
                sensorSelection = this.sensorSelection();
                if (sensorSelection.sensorName == "false")
                {
                    run = false;
                }
                else
                {
                    manager.AddedSensorToAgent(agents[0],sensorSelection);
                    manager.ActiveActivation(sensorSelection);
                    Printer.PrintCountOfWeaknesses(HelpManager.CountingTheNumberOfWeaknessesInAnAgent(agents[0]));
                    Printer.PrintCountOfCorrectSensor(manager.FindingTheNumberOfCorrectSensorsConnected(agents[0]));
                    run = manager.CheckingIfTheGameComplete(agents[0]);

                }
            }
        }
        public ISensor sensorSelection()
        {
            string choice;
            Printer.PrintStartMenu();
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    return new AudioSensor("AudioSensor");
                case "2":
                    return new ThermalSensor("ThermalSensor");
                case "3":
                    return new PlusSensor("PlusSensor");
                case "4":
                    return new AudioSensor("false");
                default:
                    return sensorSelection();
            }
        }
        public void Create()
        {
            AudioSensor audio = new AudioSensor("AudioSensor");
            PlusSensor plusSensor = new PlusSensor("PlusSensor");
            List<ISensor> sensors = new List<ISensor>();
            sensors.Add(audio);
            sensors.Add(audio);
            sensors.Add(plusSensor);
            SquadLeader agent = new SquadLeader("chaim", sensors.ToArray());
            agents.Add(agent); 
        }
    }
}
