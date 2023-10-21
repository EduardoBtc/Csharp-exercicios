using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee, secondEmployee;
            firstEmployee = new Employee();
            secondEmployee = new Employee();

            Console.WriteLine("Dados do primeiro funcionário:");

            Console.Write("Nome: ");
            firstEmployee.Name = Console.ReadLine();

            Console.Write("Salário: ");
            firstEmployee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");

            Console.Write("Nome: ");
            secondEmployee.Name = Console.ReadLine();

            Console.Write("Salário: ");
            secondEmployee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double averageSalary = (firstEmployee.Salary + secondEmployee.Salary) / 2.0 ;

            Console.WriteLine($"Salário médio = {averageSalary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}