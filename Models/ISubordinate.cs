
namespace EmployeesSalaries.Models
{
    public interface ISubordinate<T>
    {
        T Manager { get; set; }
    }
}
