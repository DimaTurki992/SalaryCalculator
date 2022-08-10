
namespace SalaryCalculator.Models
{
    public class SalesEmployee : Employee, IManaged<Manager>
    {
        private const decimal Target = 1000;
        private const double CommissionPercentage = 0.15;

        public Manager Manager { get; set; }
        object IManaged.Manager { get; set; }

        public decimal SalesAmount { get; }
        public SalesEmployee(int id, decimal basicSalary, decimal salesAmount) : base(id, basicSalary)
        {
            this.SalesAmount = salesAmount;
        }

        public override decimal GetTotalSalary()
        {
            return BasicSalary + GetCommission();
        }

        public decimal GetCommission()
        {
            return (SalesAmount >= Target) ? (SalesAmount * (decimal)CommissionPercentage) : 0;
        }
    }

}
