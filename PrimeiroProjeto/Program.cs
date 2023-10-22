using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Nome do aluno: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            student.NoteOne = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.NoteTwo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.NoteThree = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL = {student.calculateNoteEnd().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine(student.checkStudentPass());
        }
    }
}