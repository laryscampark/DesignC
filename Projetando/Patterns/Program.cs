using Patterns.ConcreateCreator;
using Patterns.Creator;
using Patterns.Product;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoFactory cartaoFactory = null;
            Console.Write("Digite o tipo de cartão que gostaria de obter:");
            string console = Console.ReadLine();

            switch (console.ToLower())
            {
                case "black":
                    cartaoFactory = new BlackFactory(50000, 0);
                    break;
                case "titanium":
                    cartaoFactory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    cartaoFactory = new PlatinumFactory(50000, 1000);
                    break;
                default:
                    break;
            }

            CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
            Console.WriteLine("\nOs detalhes do seu cartão estão abaixo: \n");
            Console.WriteLine("\nTipo de Cartão: {0}\nCrédito limite: {1}\nCobrança Anual: {2}",
                cartaoCredito.TipoCartao, cartaoCredito.LimiteCartao, cartaoCredito.CobrancaAnual);
            Console.ReadKey();
        }
    }
}
