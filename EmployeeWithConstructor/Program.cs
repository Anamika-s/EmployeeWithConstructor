using System;
using System.Collections.Generic;

namespace EmployeeWithConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Employee employee5 = new Employee();
            employee5.GetDetails();
            list.Add(employee5);
            Employee employee1 = new Employee(1, "Ajay");
            list.Add(employee1);

            Employee employee2 = new Employee(1, "Deepak", 12000, 3);
            list.Add(employee2);
            // NAMED PARAMETER
            Employee employee3 = new Employee(name: "Lalit", id: 3, exp: 8, basicSalary: 12000);
            list.Add(employee3);

            foreach (Employee employee in list)
            {
                employee.CalculateSalary();
                employee.DisplayDetails();
            }
            Console.WriteLine("Company Name is "  + Employee.comapanyName);
            Employee.DisplayManagerName();
            Console.WriteLine("No of Employees are " + list.Count);
       }
    }
}
