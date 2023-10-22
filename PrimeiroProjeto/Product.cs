using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Product
    {
        private string _name;
        private double _price;
        private int _quantity;

        public Product()
        {

        }

        public Product(string name, double price)
        {
            this._name = name;
            this._price = price;
        }

        public Product(string name, double price, int quantity)
        {
            this._name = name;
            this._price = price;
            this._quantity = quantity;
        }

        public string GetName()
        {
            return this._name;
        }

        public void SetName(string name)
        {
            if (name != null)
                this._name = name;
        }

        public double GetPrice()
        {
            return this._price;
        }

        public int GetQuantity()
        {
            return this._quantity;
        }

        public double ValorTotalEmEstoque()
        {
            return _price * _quantity;
        }

        public void AdicionarProdutos(int quantity)
        {
            this._quantity += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            this._quantity -= quantity;
        }

        public override string ToString()
        {
            return this._name + ", $ "
                + this._price.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + this._quantity
                + " unidades, Total: $ " 
                + this.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
