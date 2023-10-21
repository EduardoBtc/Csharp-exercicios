using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Product
    {
        public string Name;
        public double price;
        public int quantity;

        public double ValorTotalEmEstoque()
        {
            return price * quantity;
        }

        public void AdicionarProdutos(int quantity)
        {
            this.quantity += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            this.quantity -= quantity;
        }

        public override string ToString()
        {
            return this.Name + ", $ "
                + this.price.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + this.quantity
                + " unidades, Total: $ " 
                + this.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
