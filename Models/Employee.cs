
namespace SalaryCalculator.Models
{
    public class Employee
    {
        public int Id { get; }
        public double BasicSalary { get; }
        public Employee(int id, double basicSalary)
        {
            this.Id = id;
            this.BasicSalary = basicSalary;
        }
        public virtual double GetTotalSalary()
        {
            return BasicSalary;
        }

    }
}
