using EmployeeNamespace;
using CompanyEnums;

class Program
{
    static void Main(string[] args)
    {
        // Create an employee
        Employee emp = new Employee { Name = "Alice", HourlyPay = 25.50 };
        emp.DisplayPermissions();  // Output: Alice has the following permissions: Read, Write

        Console.WriteLine(emp.Permissions);
        Console.WriteLine((int)emp.Permissions);

        // Assign Execute permission to the employee
        emp.AssignPermissions(Permissions.Execute);
        emp.DisplayPermissions();  // Output: Alice has the following permissions: Read, Write, Execute

        // Create a manager
        Manager mgr = new Manager { Name = "Bob", HourlyPay = 50.00 };
        mgr.DisplayPermissions();  // Output: Bob has the following permissions: Read, Write, Execute, Delete

        // Check if manager has Delete permission
        bool canDelete = mgr.HasPermission(Permissions.Delete);
        Console.WriteLine($"Can manager delete? {canDelete}");  // Output: Can manager delete? True
    }
}
