
using CompanyEnums;

namespace EmployeeNamespace
{
    public class Manager : Employee
    {
        public int YearlyBonus { get; set; }
        public List<Employee> Employees { get; set; }

        public Manager() 
        { 
            Permissions = Permissions.Read | Permissions.Write | Permissions.Execute | Permissions.Delete; 
        }
    }
}
