namespace Employees.Models
{
    public class LeadDeveloper :  EmployeeWithManager
    {
        /// <summary>
        /// string name, double salary 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        public LeadDeveloper(string name, double salary) : base(name, salary)
        {
        }

    }
}
