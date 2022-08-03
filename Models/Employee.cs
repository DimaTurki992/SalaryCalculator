
namespace EmployeesSalaries.Models
{
    public class Employee
    {
        public double BasicSalary { get; set; }
        public virtual double GetTotalSalary()
        {
            return BasicSalary;
        }

    }
}
