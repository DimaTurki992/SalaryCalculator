using Microsoft.AspNetCore.Mvc;
using SalaryCalculator.Models;
using System;
using System.Linq;

namespace ManagerController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManagerController : Controller
    {
        public ManagerController()
        {
        }

        [HttpPut]
        public bool TryUpdateEmployeeManager(int employeeId, int managerId)
        {
            Employee employee = DataAccess.Employees.Where(emp => emp.Id == employeeId).FirstOrDefault();
            Employee manager = DataAccess.Employees.Where(emp => emp.Id == managerId).FirstOrDefault();
            if (employee == null || manager == null)
            {
                throw new ArgumentNullException();
            }
            IManaged managed = employee as IManaged;
            Type managerRequiredType = managed.GetType().GetProperty("Manager").PropertyType;
            if (managed != null && manager.GetType() == managerRequiredType)
            {
                managed.Manager = manager;
                return true;
            }
            return false;
        }
    }
}

