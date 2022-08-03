namespace Employees.Models
{
    public class Sales :  EmployeeWithManager
    {
        private readonly double target = 1000;
        private readonly double sales;

        public Sales(string name, double salary, double sales) : base(name, salary)
        {
            this.sales = sales;
        }

        public override double Salary => sales > target ? base.Salary + 0.15 * sales : base.Salary;

    }
}
