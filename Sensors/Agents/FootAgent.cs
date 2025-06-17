using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors
{
    internal class FootAgent : Agent,  IAgent
    {
        public FootAgent(string name, ISensor[] sensors) : base (name, sensors)
        {

        }
    }
}
