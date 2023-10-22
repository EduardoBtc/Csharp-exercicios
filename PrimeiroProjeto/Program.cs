using System;
using System.Collections.Concurrent;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA = {rectangle.calculateArea()}");
            Console.WriteLine($"PERÍMETRO =  {rectangle.calculatePerimeter().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {rectangle.calculateDiagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}