using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.LiskovSubstitution
{
    /*
     TeslaRealCar inherit CarFactory and support all methods
     */
    public class TeslaRealCar : CarFactory
    {
        public override void fuel()
        {
        }
        public override void wheels()
        {
        }
        public override void run()
        {
        }
    }
}
