using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Vamos calcular o salário de um funcionario multiplicando a quantidade de horas pelo valor hora");
            Console.WriteLine("Entre com o total que horas trabalhadas");
            int totalHours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o valor hora");
            int valueHour = int.Parse(Console.ReadLine());

            double salaryCalculate = (double)valueHour * totalHours;  

            Console.WriteLine($"O valor do salário é :{salaryCalculate.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}