using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.DependencyInversion.GoodImplementation
{
    internal class NoSqlRepositorySolution : Repository
    {
        public void save()
        {
            throw new NotImplementedException();
        }
    }
}
