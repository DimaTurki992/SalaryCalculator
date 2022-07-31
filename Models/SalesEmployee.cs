﻿
namespace EmployeesSalaries.Models
{
    public class SalesEmployee : Employee, ISubordinate<Manager>
    {
        private const double Target = 1000;
        private const double CommissionPercentage = 0.15;

        public SalesEmployee(double basicSalary, double salesAmount)
        {
            this.BasicSalary = basicSalary;
            this.SalesAmount = salesAmount;
        }

        public Manager Manager { get; set; }
        public double SalesAmount { get; set; }

        public override double FinalSalary
        {
            get { return BasicSalary + Commission; }
        }

        private double Commission
        {
            get
            {
                if (SalesAmount >= Target)
                {
                    return SalesAmount * CommissionPercentage;
                }
                return 0;
            }
        }

    }

}
