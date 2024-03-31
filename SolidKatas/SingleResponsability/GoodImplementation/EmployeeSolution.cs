using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidKatas.SingleResponsability.GoodImplementation
{
    //Only standard getters ans setters methods
    public class EmployeeSolution
    {
        private string fullName { get; set; }
        private string dateOfJoining { get; set; }
        private double annualSalaryPackage { get; set; }
    }
}
