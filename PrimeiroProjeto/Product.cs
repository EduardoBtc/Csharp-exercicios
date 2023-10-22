using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Product
    {
        private string _name;
        public double Price {  get; private set; }
        public int Quantity { get; private set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            this._name = name;
            this.Price = price;
        }

        public Product(string name, double price, int quantity)
        {
            this._name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name
        {
            get 
            { 
                return _name; 
            }

            set
            {
                if (value != null)
                    this._name = value;
            }

        }

        public double ValorTotalEmEstoque()
        {
            return Price * Quantity;
        }

        public void AdicionarProdutos(int quantity)
        {
            this.Quantity += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            this.Quantity -= quantity;
        }

        public override string ToString()
        {
            return this._name + ", $ "
                + this.Price.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + this.Quantity
                + " unidades, Total: $ " 
                + this.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
