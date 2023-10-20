using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        private static readonly double piValue = 3.14159;

        static void Main(string[] args)
        {

            Console.WriteLine("Vamos somar a área de um circulo");
            Console.WriteLine("Entre com o raio desse circulo");
            double circleRadius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             
            double areaValue = piValue * (Math.Pow(circleRadius, 2));

            Console.WriteLine($"O valor da área é :{areaValue.ToString("F4",CultureInfo.InvariantCulture)}");
        }
    }
}