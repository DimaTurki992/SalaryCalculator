
namespace SalaryCalculator.Models
{
    public class Developer: Employee, IManaged<LeadDeveloper>
    {
        public LeadDeveloper Manager { get; set; }
        object IManaged.Manager { get; set; }

        public Developer(int id, double basicSalary): base (id, basicSalary)
        {
        }
    }
}
