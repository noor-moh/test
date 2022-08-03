using Employees.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Controllers
{
    /// <summary>
    /// Sales Controller
    /// </summary>
    [Route("api/v1/sales")]
    [Produces("application/json")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        /// <summary>
        /// sales  sales person salary : double , bonus :double 
        /// </summary>
        /// <returns>salary value</returns>
        [HttpGet("calculate-salary")]
        public double CalculateSalary([FromQuery] double salary, [FromQuery] double sales)
        {
            var salesPerson = new Sales("Zack", salary, sales);
            return salesPerson.Salary;
        }

        /// <summary>
        /// Set Manager
        /// </summary>
        /// <param name="manager"></param>
        /// <returns>manager value</returns>
        [HttpPost("set-manager")]
        public Manager SetEmployeeManager([FromBody] Manager manager)
        {
            var salesPerson = new Sales("Zack", 1000, 2000);
            salesPerson.Manager = manager;
            return salesPerson.Manager;
        }
    }
}
