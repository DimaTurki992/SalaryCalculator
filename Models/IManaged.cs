
namespace SalaryCalculator.Models
{
    public interface IManaged<T> : IManaged
    {
        new T Manager { get; set; }
    }

    public interface IManaged
    {
        object Manager { get; set; }
    }
}
