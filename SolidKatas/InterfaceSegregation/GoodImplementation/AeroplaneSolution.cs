using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.InterfaceSegregation.GoodImplementation
{
    public class AeroplaneSolution : VehicleSolution, Flyable
    {
        public void accelerate()
        {
            throw new NotImplementedException();
        }

        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void fly()
        {
            throw new NotImplementedException();
        }
    }
}
