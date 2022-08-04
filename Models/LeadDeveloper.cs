
namespace SalaryCalculator.Models
{
    public class LeadDeveloper : Employee, IManaged<Manager>
    {
        public Manager Manager { get; set; }
        public LeadDeveloper(int id, double basicSalary): base (id, basicSalary) { }

        public void SetManager(Manager manager)
        {
            this.Manager = manager;
        }
    }
}
