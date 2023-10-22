namespace PrimeiroProjeto
{
    internal class Rectangle
    {
        public double Width;
        public double Height;

        public double calculateArea()
        {
            return this.Width * this.Height;
        }

        public double calculatePerimeter()
        {
            return 2 * (this.Width + this.Height);
        }

        public double calculateDiagonal()
        {
            return Math.Sqrt(Math.Pow(this.Width, 2) + Math.Pow(this.Height, 2));
        }
    }
}
