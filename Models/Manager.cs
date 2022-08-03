using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesSalaries.Models
{
    public class Manager : Employee
    {
        public double Bonus { get; set; }
        public override double GetTotalSalary()
        {
            return BasicSalary + Bonus;
        }

    }
}
