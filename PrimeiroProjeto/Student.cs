using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Student
    {
        public string Name;
        public double NoteOne;
        public double NoteTwo;
        public double NoteThree;
        public double minimumNotePass = 60.0;

        public double calculateNoteEnd()
        {
            return this.NoteOne + this.NoteTwo + this.NoteThree;
        }

        public string checkStudentPass()
        {
            double finalNote = calculateNoteEnd();

            return finalNote >= minimumNotePass 
                ? "APROVADO" 
                : $"REPROVADO \nFALTARAM {(minimumNotePass - finalNote).ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
        }
    }
}
