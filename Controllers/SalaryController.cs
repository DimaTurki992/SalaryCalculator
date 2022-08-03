using EmployeesSalaries.Models;
using Microsoft.AspNetCore.Mvc;

namespace SalaryCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalaryController : ControllerBase
    {
        public SalaryController()
        {
        }

        [HttpGet("developer")]
        public double GetDeveloperSalary(double basicSalary)
        {
            Developer developer = new Developer(basicSalary);
            return developer.GetTotalSalary();
        }

        [HttpGet("lead-developer")]
        public double GetLeadDeveloperSalary(double basicSalary)
        {
            LeadDeveloper leadDeveloper = new LeadDeveloper(basicSalary);
            return leadDeveloper.GetTotalSalary();
        }

        [HttpGet("HR-officer")]
        public double GetHRSalary(double basicSalary)
        {
            HROfficer hr = new HROfficer(basicSalary);
            return hr.GetTotalSalary();
        }

        [HttpGet("manager")]
        public double GetManagerSalary(double basicSalary, double bonus)
        {
            Manager manager = new Manager(basicSalary, bonus);
            return manager.GetTotalSalary();
        }

        [HttpGet("sales-employee")]
        public double GetSalesEmployeeSalary(double basicSalary, double salesAmount)
        {
            SalesEmployee salesEmp = new SalesEmployee(basicSalary, salesAmount);
            return salesEmp.GetTotalSalary();
        }
    }
}
