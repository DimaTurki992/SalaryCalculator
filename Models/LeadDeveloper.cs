
namespace SalaryCalculator.Models
{
    public class LeadDeveloper : Employee, IManaged<Manager>
    {
        public Manager Manager { get; set; }
        object IManaged.Manager { get; set; }

        public LeadDeveloper(int id, double basicSalary): base (id, basicSalary) { }
    }
}
