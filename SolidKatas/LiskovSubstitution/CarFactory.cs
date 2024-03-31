using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.LiskovSubstitution
{
    /*
     Child Classes should be replaceable with Parent Classes without breaking the behavior of our code.
     */
    public class CarFactory
    {
        public virtual void fuel()
        {
            //implement fuel
        }
        public virtual void wheels()
        {
            //implement fuel
        }
        public virtual void run()
        {
            //implement fuel
        }
    }

 


}
