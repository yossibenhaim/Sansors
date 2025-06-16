using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class AudioSensor : ISensor
    {
        public string name { get; }

        public bool active { get; private set; } = false;

        public AudioSensor(string name)
        {
            this.name = name;
        }
        public void SetActive()
        {
            active = true;
        } 
    }
}