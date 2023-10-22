using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Employee
    {
        public string Name;
        public double GrossSalary;
        public double GovernmentTax;

        public double SalarioLiquido()
        {
            return (this.GrossSalary - this.GovernmentTax);
        }

        public void AumentarSalario(double percentage)
        {
            this.GrossSalary += this.GrossSalary / percentage;
        }

        public override string ToString()
        {
            return this.Name + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
