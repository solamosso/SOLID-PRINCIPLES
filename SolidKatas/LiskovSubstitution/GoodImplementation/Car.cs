using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.LiskovSubstitution.GoodImplementation
{
    /*
     
    Creating new subclass RealCar from parent Car class, so that RealCar can support fuel() and Car 
    can support generic functions support by any type of car.
    As shown below, TeslaToyCar and TeslaRealCar can be substituted with their respective Parent class.
     */
    public class Car
    {
        public virtual void wheels()
        {
            //implement fuel
        }
        public virtual void run()
        {

        }
    }
}
