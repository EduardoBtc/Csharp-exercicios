using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular a soma dos números de entrada");

            Console.WriteLine("Digite o primeiro número");
            int numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número");
            int numberSecond = int.Parse(Console.ReadLine());

            int numberSum = numberOne + numberSecond;

            Console.WriteLine($"A soma dos números é: {numberSum}");

        }
    }
}