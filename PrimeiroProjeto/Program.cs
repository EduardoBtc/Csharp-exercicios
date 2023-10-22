using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double dolarPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double dolarQuantity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais = " +
                    $"{ConversorDeMoeda.ConvertDolarToReal(dolarPrice, dolarQuantity).ToString("F2", CultureInfo.InvariantCulture)}"
                );
        }
    }
}