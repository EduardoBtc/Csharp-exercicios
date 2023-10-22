using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Nome: ");
            employee.Name = Console.ReadLine();

            Console.Write("Salário bruto: ");
            employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            employee.GovernmentTax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {employee}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            employee.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine($"Dados atualizados: {employee}");

        }
    }
}