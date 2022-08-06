
namespace SalaryCalculator.Models
{
    public class HROfficer : Employee, IManaged<Manager>
    {
        public Manager Manager { get; set; }
        object IManaged.Manager { get; set; }
        public HROfficer(int id, double basicSalary): base (id, basicSalary) { }

    }
}
