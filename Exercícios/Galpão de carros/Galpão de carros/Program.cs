using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galpão_de_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            int q;

            Console.WriteLine("Informe o número de carros no galpão");
            q = int.Parse(Console.ReadLine());

            Carro[] carrocho = new Carro[q];

            for (int i = 0; i < q; i++)
            {
                carrocho[i] = new Carro();

                Console.WriteLine("\nEscreva o modelo do carro");
                carrocho[i].mol = Console.ReadLine();

                Console.WriteLine("\nEscreva o número de km rodados");
                carrocho[i].km = double.Parse(Console.ReadLine());

                Console.WriteLine("\nEscreva a potência do motor");
                carrocho[i].pot = double.Parse(Console.ReadLine());

                Console.WriteLine("\nEscreva o ano de fabricação");
                carrocho[i].anocar = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < q; i++)
            {
                Console.WriteLine(carrocho[i].Classificar());

            }
        }
    }
}
