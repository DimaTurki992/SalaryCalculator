using System.Collections.Generic;
using System.Linq;

namespace SalaryCalculator.Models
{
    public class DataAccess
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Developer(1, 1000),
            new LeadDeveloper(2, 2000),
            new HROfficer(3, 1000),
            new SalesEmployee(4, 1000, 10000),
            new Manager(5, 3000, 1000)
        };
    }
}
