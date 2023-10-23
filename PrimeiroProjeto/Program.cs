using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int numberRooms = int.Parse(Console.ReadLine());

            Room[] rooms = new Room[9];

            for (int i = 1; i <= numberRooms; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                rooms[quarto] = new Room(name, email, quarto);
            }

            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] == null)
                    continue;

                Console.WriteLine();
                Room currentRoom = rooms[i];
                Console.WriteLine("Quartos ocupados:");
                Console.WriteLine($"{i}: {currentRoom}");
            }
        }
    }
}