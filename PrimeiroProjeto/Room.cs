namespace PrimeiroProjeto
{
    internal class Room
    {
        public string PersonName { get; private set; }
        public string PersonEmail { get; private set; }
        public int numberRoom { get; private set; }

        public Room(string personName, string personEmail, int numberRoom)
        {
            this.PersonName = personName;
            this.PersonEmail = personEmail;
            this.numberRoom = numberRoom;
        }

        public override string ToString()
        {
            return PersonName + ", " + PersonEmail;
        }
    }
}
