using Employees.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Controllers
{
    /// <summary>
    /// HumanResources Controller
    /// </summary>
    [Route("api/v1/hr")]
    [Produces("application/json")]
    [ApiController]
    public class HumanResourcesController : ControllerBase
    {
        /// <summary>
        /// HR salary : double
        /// </summary>
        /// <returns>salary value </returns>
        [HttpGet("calculate-salary")]
        public double CalculateSalary([FromQuery] double salary)
        {
            var hr = new HumanResources("Zack", salary);
            return hr.Salary;
        }

        /// <summary>
        /// Set Manager
        /// </summary>
        /// <param name="manager">manager value</param>
        [HttpPost("set-manager")]
        public Manager SetEmployeeManager([FromBody] Manager manager)
        {
            var hr = new HumanResources("Zack", 1000);
            hr.Manager = manager;
            return hr.Manager;
        }
    }
}
