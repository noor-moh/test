using Employees.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Controllers
{
    /// <summary>
    ///  Developers Controller
    /// </summary>
    [Route("api/v1/developer")]
    [Produces("application/json")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        /// <summary>
        /// Calculate Developers salary : double
        /// </summary>
        /// <param name="salary">: double</param>
        /// <returns>salary value</returns>
        [HttpGet("calculate-salary")]
        public double CalculateSalary([FromQuery] double salary)
        {
            var dev = new Developer("Noor", salary);
            return dev.Salary;
        }

        /// <summary>
        /// Set manager of type LeadDeveoper
        /// </summary>
        /// <param name="manager"> manager value </param>
        [HttpPost("set-manager")]
        public LeadDeveloper SetEmployeeManager([FromBody] LeadDeveloper manager)
        {
            var dev = new Developer("Zack", 1000);
            dev.Manager = manager;
            return dev.Manager;
        }
    }
}
