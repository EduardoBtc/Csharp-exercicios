using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vamos calcular a diferença entre os quatro números inseridos");
            Console.WriteLine("Digite o primeiro número");
            int numberFirst = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int numberSecond = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número");
            int numberthree = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto número");
            int numberFor = int.Parse(Console.ReadLine());

            int difference = (numberFirst * numberSecond - numberthree * numberFor);

            Console.WriteLine($"A diferença é: {difference}");
        }
    }
}