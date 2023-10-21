using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            product.Name = Console.ReadLine();

            Console.Write("Preço: ");
            product.price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            product.quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + product);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            product.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados do ataualizados: " + product);

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            product.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados do ataualizados: " + product);
        }
    }
}