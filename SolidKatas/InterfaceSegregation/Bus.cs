using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.InterfaceSegregation
{
    /*
     Vehicle interface contains the fly() method which is not supported by all vehicles i.e. Bus, Car, etc. 
    Hence they've to forcefully provide a dummy implementation.
     It violates the Interface Segregation principle as shown below:
     */
    internal class Bus : Vehicle
    {
        public void accelerate()
        {
        }

        public void Brake()
        {
        }

        public void fly()
        {
            // dummy implementation
        }
    }
}
