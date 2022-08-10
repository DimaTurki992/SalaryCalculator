
namespace SalaryCalculator.Models
{
    public class Manager : Employee
    {
        public decimal Bonus { get; }
        public Manager(int id, decimal basicSalary, decimal bonus) : base(id, basicSalary)
        {
            this.Bonus = bonus;
        }

        public override decimal GetTotalSalary()
        {
            return BasicSalary + Bonus;
        }

    }
}
