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
    [Route("api/v1/lead")]
    [Produces("application/json")]
    [ApiController]
    public class LeadDeveloperController : ControllerBase
    {
        /// <summary>
        ///Lead Salary
        /// </summary>
        /// <returns>salary value </returns>
        [HttpGet("calculate-salary")]
        public double CalculateSalary([FromQuery] double salary)
        {
            var lead = new LeadDeveloper("Lead", salary);
            return lead.Salary;
        }
        /// <summary>
        /// Set Manager
        /// </summary>
        /// <param name="manager">managervalye </param>
        [HttpPost("set-manager")]
        public Manager SetEmployeeManager([FromBody] Manager manager)
        {
            var dev = new LeadDeveloper("Zack", 1000);
            dev.Manager = manager;
            return dev.Manager;
        }
    }
}
