namespace PrimeiroProjeto
{
    internal class ConversorDeMoeda
    {
        private static double taxIOF = 6.0;

        public static double ConvertDolarToReal(double dolarPrice, double value) 
        {
            double total = value * dolarPrice;
            return total + total * taxIOF / 100.0;
        }

    }
}
