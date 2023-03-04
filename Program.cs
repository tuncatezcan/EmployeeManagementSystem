using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "John Doe", Position = "Manager", Salary = 50000 },
                new Employee { Id = 2, Name = "Jane Doe", Position = "Developer", Salary = 60000 },
                new Employee { Id = 3, Name = "Jim Smith", Position = "Designer", Salary = 55000 }
            };

            Console.WriteLine("Enter the employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Employee selectedEmployee = employees.Find(employee => employee.Id == id);

            if (selectedEmployee == null)
            {
                Console.WriteLine("Employee not found.");
            }
            else
            {
                Console.WriteLine("Name: " + selectedEmployee.Name);
                Console.WriteLine("Position: " + selectedEmployee.Position);
                Console.WriteLine("Salary: $" + selectedEmployee.Salary);
            }

            Console.ReadLine();
        }
    }
}
