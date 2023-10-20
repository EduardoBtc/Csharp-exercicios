using System;
using System.Collections.Concurrent;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string namePerson = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int badroomQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double productValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] nameAgeHeight = Console.ReadLine().Split(" ");
            string lastName = nameAgeHeight[0];
            int age = int.Parse(nameAgeHeight[1]);
            double height = double.Parse(nameAgeHeight[2]);

            Console.WriteLine(namePerson);
            Console.WriteLine(badroomQuantity);
            Console.WriteLine(productValue.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString(CultureInfo.InvariantCulture));
        }
    }
}