using System;

namespace Employees.Models
{
    /// <summary>
    /// string name, double salary,double bonus
    /// </summary>
    public class Manager : Employee
    {
        private readonly double bonus;

        public Manager(string name, double salary, double bonus) : base(name, salary)
        {
            this.bonus = bonus;
        }

        public override double Salary => base.Salary + bonus;

    }
}
