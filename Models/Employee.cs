
namespace EmployeesSalaries.Models
{
    public class Employee
    {
        public double BasicSalary { get; set; }
        public virtual double FinalSalary
        {
            get { return BasicSalary; }
        }

    }
}
