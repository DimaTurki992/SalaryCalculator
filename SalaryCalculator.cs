

using SalaryCalculator.Models;

namespace SalaryCalculator
{
    public class SalaryCalculator
    {
        public decimal GetTotalSalaries(Employee[] employees)
        {
            decimal total = 0;
            foreach (var emp in employees)
            {
                total += emp.GetTotalSalary();
            }
            return total;
        }
    }
}
