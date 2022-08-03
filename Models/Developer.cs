
namespace EmployeesSalaries.Models
{
    public class Developer: Employee, IManaged<LeadDeveloper>
    {
        public Developer(double basicSalary)
        {
            this.BasicSalary = basicSalary;
        }
        public LeadDeveloper Manager { get; set; }
        
    }
}
