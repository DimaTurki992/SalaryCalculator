using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesSalaries.Models
{
    public class LeadDeveloper : Employee, IManaged<Manager>
    {
        public LeadDeveloper(double basicSalary)
        {
            this.BasicSalary = basicSalary;
        }
        public Manager Manager { get; set; }
        
    }
}
