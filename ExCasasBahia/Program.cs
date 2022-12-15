using System.Diagnostics.Contracts;
using System.Globalization;
using ExCasasBahia.Entities;
using ExCasasBahia.Services;
using System.Globalization;

namespace ExCasasBahia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Infome os dados da compra");
            Console.Write("Compra Número: "); int numCompra = int.Parse(Console.ReadLine());
            Console.Write("Data: "); DateTime dataCompra = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor: "); double valorTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Parcelas: "); int parcelas = int.Parse(Console.ReadLine());

            Compra compra = new Compra(numCompra, dataCompra, valorTotal);

            ServicoDeCompra servicoDeCompra = new ServicoDeCompra(new ServicoPayPal());
            servicoDeCompra.GerarCompra(compra, parcelas);

            Console.WriteLine("Financiamento:");

            int i = 0;
            foreach (Financiamento financiamento in compra.Financiamentos)
            {
                Console.WriteLine((i + 1) + "º Parcela " + financiamento);
                i = i + 1;


            }
        }
    }
}