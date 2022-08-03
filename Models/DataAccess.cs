using EmployeesSalaries.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculator.Models
{
    public class DataAccess
    {
        public static List<Employee> Data = new List<Employee>()
        {
            new Developer()
            {
                Id = 1,
                BasicSalary = 1000
            },
            new LeadDeveloper()
            {
                Id = 2,
                BasicSalary = 2000
            },
            new HROfficer()
            {
                Id = 3,
                BasicSalary = 1000
            },
            new SalesEmployee()
            {
                Id = 4,
                BasicSalary = 1000,
                SalesAmount = 10000
            },
            new Manager()
            {
                Id = 5,
                BasicSalary = 3000,
                Bonus = 1000
            }

        };

    }
}
