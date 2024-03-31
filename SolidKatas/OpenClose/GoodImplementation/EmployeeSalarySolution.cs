using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.OpenClose.GoodImplementation
{

    /*
     We can introduce a new interface EmployeeSalary and create two child classes for 
     Permanent and Contractual Employees.
     By doing this, when a new type comes then a new child class needs to be created and 
     our core logic will also not change from this.
     */
    public interface EmployeeSalarySolution
    {
        public double calculateSalary();
    }
}
