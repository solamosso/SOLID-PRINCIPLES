using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.DependencyInversion
{

    /*
     We've got a Service class, in which we've directly referenced concrete class(SQLRepository).
     Issue: Our class is now tightly coupled with SQLRepository, in future if we need to start 
     supporting NoSQLRepository then we need to change Service class.
     */
    public class RepositoryService
    {
        private SqlRepository repo = new SqlRepository();

        public void save()
        {
            repo.save();
        }
    }
}
