using System;
using System.Collections.Concurrent;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int numberEmployees = int.Parse(Console.ReadLine());

            List<Employee> emplyoees = new List<Employee>();

            for (int i = 1; i <= numberEmployees; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int idEmployee = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nameEmployee = Console.ReadLine();

                Console.Write("Salary: ");
                double salaryEmployee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emplyoees.Add(new Employee(idEmployee, nameEmployee, salaryEmployee));

                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idSearch = int.Parse(Console.ReadLine());

            Employee emp = emplyoees.Find(x => x.Id == idSearch);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentege = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentege);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");
            foreach (Employee currentEmployee in emplyoees)
                Console.WriteLine(currentEmployee);
        }
    }
}