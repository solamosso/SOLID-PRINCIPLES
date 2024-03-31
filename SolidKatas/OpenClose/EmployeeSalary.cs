using SolidKatas.SingleResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.OpenClose
{
    /*
     Below EmployeeSalary class calculates salary based on employee type: Permanent and Contractual.
     Issue: In the future, if a new type(Part-time Employee) comes then the code needs to be modified 
     to calculate the salary based on employee type
     */
    public class EmployeeSalary
    {
        public double calcultateSalary(Employee employee)
        {
            double salary = 0;
            if(employee.GetType().Equals("CDI"))
            {
                // compute CDI employee salary
            }
            else if (employee.GetType().Equals("CDD"))
            {
                // compute permament employee salary
            }
            else if (employee.GetType().Equals("ENTERIMAIRE"))
            {
                // compute permament employee salary
            }
            else if (employee.GetType().Equals("STAGIAIRE"))
            {
                // compute permament employee salary
            }

            return salary;
        }
    }
}
