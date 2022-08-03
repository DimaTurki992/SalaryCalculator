
namespace EmployeesSalaries.Models
{
    public interface IManaged<T>
    {
        T Manager { get; set; }
    }
}
