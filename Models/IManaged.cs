
namespace SalaryCalculator.Models
{
    public interface IManaged<T>
    {
        T Manager { get; set; }
        void SetManager(T manager);
    }
}
