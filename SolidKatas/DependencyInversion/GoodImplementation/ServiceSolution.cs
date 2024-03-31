using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.DependencyInversion.GoodImplementation
{
    public class ServiceSolution
    {
        private Repository repo;

        public ServiceSolution(Repository repo)
        {
            this.repo = repo;
        }

        public void save()
        {
            repo.save();
        }
    }
}
