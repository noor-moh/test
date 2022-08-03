namespace Employees.Models
{
    public class HumanResources :  EmployeeWithManager
    {
        public HumanResources(string name, double salary) : base(name, salary)
        {
        }

    }
}
