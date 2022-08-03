using System;

namespace Employees.Models
{
    public class Developer : EmployeeWithManager
    {
        public Developer(string name, double salary) : base(name, salary)
        {
        }
        public new LeadDeveloper Manager { set; get; }
      

    }
}
