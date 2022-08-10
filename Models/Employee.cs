
namespace SalaryCalculator.Models
{
    public class Employee
    {
        public int Id { get; }
        public decimal BasicSalary { get; }
        public Employee(int id, decimal basicSalary)
        {
            this.Id = id;
            this.BasicSalary = basicSalary;
        }
        public virtual decimal GetTotalSalary()
        {
            return BasicSalary;
        }

    }
}
