using System;

namespace Employees.Models
{
    public abstract class Employee
    {
        private readonly string name;
        private readonly double salary;

        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string Name => name;

        public virtual double Salary => salary;

    }
    public abstract class EmployeeWithManager : Employee
    {

        public EmployeeWithManager(string name, double salary) : base(name, salary)
        {
        }
        public Manager Manager { set; get; }

    }


}
