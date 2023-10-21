using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Triangulo trianguloX, trianguloY;

            trianguloX = new Triangulo();
            trianguloY = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            trianguloX.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloX.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloX.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            trianguloY.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloY.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloY.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = trianguloX.calculateArea();

            double areaY = trianguloY.calculateArea();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else 
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}