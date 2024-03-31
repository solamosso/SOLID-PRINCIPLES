using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.LiskovSubstitution
{

    /*
     TeslaToyCar extends CarFactory but doesn't support fuel() method
     because it is a toy. That a violation of Liskov principle
    So we canot substitute CarFactory by TeslaToyCar as fuel() throw an exception
     */
    public class TeslaToyCar : CarFactory
    {
        public override void fuel()
        {
            throw new NotImplementedException("No need because it is a toy");
        }
        public override void wheels()
        {
        }
        public override void run()
        {
        }
    }
}
