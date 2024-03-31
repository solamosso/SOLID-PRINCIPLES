using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.InterfaceSegregation
{

    /*
     Interface should only have methods that are applicable 
     to all child classes.
     If an interface contains a method applicable to some child classes then 
     we need to force the rest to provide dummy implementation.
     Move such methods to a new interface.
     */
    public interface Vehicle
    {
        void accelerate();
        void Brake();
        void fly();
    }
}
