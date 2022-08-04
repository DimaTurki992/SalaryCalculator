
namespace EmployeesSalaries.Models
{
    public class Developer: Employee, IManaged<LeadDeveloper>
    {
        public LeadDeveloper Manager { get; set; }
        public Developer(int id, int basicSalary): base (id, basicSalary)
        {
        }
        
    }
}
