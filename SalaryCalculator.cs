
using EmployeesSalaries.Models;

namespace SalaryCalculator
{
    public class SalaryCalculator
    {
        public double GetTotalSalaries(Employee[] employees)
        {
            double total = 0;
            foreach (var emp in employees)
            {
                total += emp.GetTotalSalary();
            }
            return total;
        }
    }
}
