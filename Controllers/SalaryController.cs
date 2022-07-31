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
            return developer.FinalSalary;
        }

        [HttpGet("lead-developer")]
        public double GetLeadDeveloperSalary(double basicSalary)
        {
            LeadDeveloper leadDeveloper = new LeadDeveloper(basicSalary);
            return leadDeveloper.FinalSalary;
        }

        [HttpGet("HR-officer")]
        public double GetHRSalary(double basicSalary)
        {
            HROfficer hr = new HROfficer(basicSalary);
            return hr.FinalSalary;
        }

        [HttpGet("manager")]
        public double GetManagerSalary(double basicSalary, double bonus)
        {
            Manager manager = new Manager(basicSalary, bonus);
            return manager.FinalSalary;
        }

        [HttpGet("sales-employee")]
        public double GetSalesEmployeeSalary(double basicSalary, double salesAmount)
        {
            SalesEmployee manager = new SalesEmployee(basicSalary, salesAmount);
            return manager.FinalSalary;
        }
    }
}
