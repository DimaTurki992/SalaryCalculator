
namespace EmployeesSalaries.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public double BasicSalary { get; set; }
        public virtual double GetTotalSalary()
        {
            return BasicSalary;
        }

    }
}
