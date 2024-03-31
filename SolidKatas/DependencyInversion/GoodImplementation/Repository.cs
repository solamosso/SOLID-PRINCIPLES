using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.DependencyInversion.GoodImplementation
{
    /*
     Create a parent interface Repository and SQL and NoSQL Repository implements it.
     Service class refers to Repository interface, in future if we need to support NoSQL then 
     simply need to pass its instance in constructor without changing Service class.
     */
    public interface Repository
    {
        void save();
    }
}
