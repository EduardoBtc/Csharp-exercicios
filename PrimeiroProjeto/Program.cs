using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Console.Write("Entre o número da conta: ");
            int bankNumber = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string bankPersonName = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string hasInitialDepository = Console.ReadLine();

            if (hasInitialDepository.Equals("s"))
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double initialDepository = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               bank = new Bank(bankNumber, bankPersonName, initialDepository);
            }

            if (hasInitialDepository.Equals("n"))
                bank = new Bank(bankNumber, bankPersonName);

            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(bank);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            bank.AddBalance(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(bank);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            bank.RemoveBalance(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(bank);
        }
    }
}