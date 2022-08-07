
namespace EmployeesSalaries.Models
{
    public class Manager : Employee
    {
        public double Bonus { get; }
        public Manager(int id, double basicSalary, double bonus) : base(id, basicSalary)
        {
            this.Bonus = bonus;
        }

        public override double GetTotalSalary()
        {
            return BasicSalary + Bonus;
        }

    }
}
