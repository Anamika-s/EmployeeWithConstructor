using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWithConstructor
{
    class Employee
    {
        int id;
        string name;
        int exp;
        static string hrManager;
        public const string comapanyName = "Wipro";
        decimal da, hra, pf, netSalary, basicSalary;
        public Employee() { }
        static Employee()
        {
            hrManager = "Ajay";

        }

        public Employee(int id, string name)
        {

            this.id = id;
            this.name = name;
            Console.WriteLine("Enter Exp");
            exp = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Basic Salary");
            basicSalary = Convert.ToInt32(Console.ReadLine());
        }
        public Employee(int id, string name, decimal basicSalary,
            int exp)
        {

            this.id = id;
            this.name = name;
            this.basicSalary = basicSalary;
            this.exp = exp;
        }
        public void GetDetails() 
        {
            Console.WriteLine("Enter Id");
            id = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            name =  Console.ReadLine();
            Console.WriteLine("Enter Exp");
            exp = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Basic Salary");
            basicSalary = Convert.ToInt32(Console.ReadLine());
        }

        public void CalculateSalary()
        {

        }
        public void DisplayDetails()
        {
        }
        public static void DisplayManagerName()
        {
            Console.WriteLine("Manager Name is  " + hrManager);
        }
    }
}
