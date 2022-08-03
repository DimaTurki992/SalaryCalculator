using EmployeesSalaries.Models;
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
        public double GetSalary(int employeeId)
        {
            Employee employee = DataAccess.Data.Where(employee => employee.Id == employeeId).FirstOrDefault();
            return employee.GetTotalSalary();
        }

    }
}
