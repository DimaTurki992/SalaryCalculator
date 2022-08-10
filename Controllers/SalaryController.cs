using Microsoft.AspNetCore.Mvc;
using SalaryCalculator.Models;
using System.Linq;

namespace SalaryCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalaryController : ControllerBase
    {
        public SalaryController()
        {
        }

        [HttpGet]
        public decimal GetSalary(int employeeId)
        {
            Employee employee = DataAccess.Employees.Where(employee => employee.Id == employeeId).FirstOrDefault();
            return employee.GetTotalSalary();
        }

    }
}
