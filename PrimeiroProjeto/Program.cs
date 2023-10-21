using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson, secondPerson;
            firstPerson = new Person();
            secondPerson = new Person();

            Console.WriteLine("Dados da primeira pessoa:");

            Console.Write("Nome: ");
            firstPerson.Name = Console.ReadLine();

            Console.Write("Idade: ");
            firstPerson.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");

            Console.Write("Nome: ");
            secondPerson.Name = Console.ReadLine();

            Console.Write("Idade: ");
            secondPerson.Age = int.Parse(Console.ReadLine());

            string olderPersonName = firstPerson.Age > secondPerson.Age 
                    ? firstPerson.Name 
                    : secondPerson.Name;

            Console.WriteLine($"Pessoa mais velha: {olderPersonName}");
        }
    }
}