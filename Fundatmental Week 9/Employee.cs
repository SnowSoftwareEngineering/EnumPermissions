using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyEnums;

namespace EmployeeNamespace
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public double HourlyPay { get; set; }
        public Permissions Permissions { get; set; }
        public List<Client> MyClientList { get; set; } = new List<Client>();

        public Employee()
        {
            // Default permissions for each employee
            Permissions = Permissions.Read | Permissions.Write;
        }

        public void AssignPermissions(Permissions permissions)
        {
            Permissions |= permissions;
        }

        public bool HasPermission(Permissions permission)
        {
            return (Permissions & permission) == permission;
        }

        public void DisplayPermissions()
        {
            Console.WriteLine($"{Name} has the following permissions: {Permissions}");
        }
    }
}
