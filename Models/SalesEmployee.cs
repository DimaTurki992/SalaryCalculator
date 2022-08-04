
namespace SalaryCalculator.Models
{
    public class SalesEmployee : Employee, IManaged<Manager>
    {
        private const double Target = 1000;
        private const double CommissionPercentage = 0.15;

        public Manager Manager { get; set; }
        public double SalesAmount { get; }
        public SalesEmployee(int id, double basicSalary, double salesAmount) : base(id, basicSalary)
        {
            this.SalesAmount = salesAmount;
        }

        public override double GetTotalSalary()
        {
            return BasicSalary + GetCommission();
        }

        public double GetCommission()
        {
            return (SalesAmount >= Target) ? (SalesAmount * CommissionPercentage) : 0;
        }

        public void SetManager(Manager manager)
        {
            this.Manager = manager;
        }
    }

}
