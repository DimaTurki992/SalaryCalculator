using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesSalaries.Models
{
    public class Manager : Employee
    {
        public Manager(double basicSalary, double bonus)
        {
            this.BasicSalary = basicSalary;
            this.Bonus = bonus;
        }
        public double Bonus { get; set; }
        public override double GetTotalSalary()
        {
            return BasicSalary + Bonus;
        }

    }
}
