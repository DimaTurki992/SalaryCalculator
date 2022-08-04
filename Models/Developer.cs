
namespace SalaryCalculator.Models
{
    public class Developer: Employee, IManaged<LeadDeveloper>
    {
        public LeadDeveloper Manager { get; set; }
        public Developer(int id, double basicSalary): base (id, basicSalary)
        {
        }

        public void SetManager(LeadDeveloper manager)
        {
            this.Manager = manager;
        }
    }
}
