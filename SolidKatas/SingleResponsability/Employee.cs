using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.SingleResponsability
{

    /*
     
    A class should always have one responsibility and there should be only a single reason to change it.

    Below Employee class contains personal details, business logic to perform a few calculations, and DB logic to save/update.
    Our class is tightly coupled, hard to maintain, multiple reasons to modify this class.
     */
    public class Employee
    {
        private string fullName { get; set; }
        private string dateOfJoining { get;set; }
        private double annualSalaryPackage { get; set; }


        #region business logic
        public double calculateEmployeeSalary(Employee employee)
        {
            //implemente salalry calculation here

            return 0;
        }
        public double calculateEmployeeLeaves(Employee employee)
        {
            //calculate salary

            return 0;
        }

        public double calculateTaxOnEmployee(Employee employee)
        {
            //calculate taxs here

            return 0;
        }
        #endregion


        #region    data persistance logic

        public Employee saveEmployee(Employee employee)
        {
            // implement save
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            // implement update
            return employee;
        }
        #endregion


    }
}
