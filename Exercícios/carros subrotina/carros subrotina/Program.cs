using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentando
{
    class Program
    {
        struct Carro
        {
            public string mol;
            public double km;
            public double pot;
            public int anofabri;
            
            
        }

        static void Main(string[] args)
        {
            int q;
            string socorro;

            Console.WriteLine("Qual o número de carros no galpão?");
            q = int.Parse(Console.ReadLine());

            Carro[] carrocho = new Carro[q];

            for (int i = 0; i < q; i++)
            {
                Console.WriteLine("\nInforme o modelo do carro");
                carrocho[i].mol = Console.ReadLine();

                Console.WriteLine("\nInforme o número de km rodados");
                carrocho[i].km = double.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme a potência do motor");
                carrocho[i].pot = double.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme o ano de fabricação do carro");
                carrocho[i].pot = double.Parse(Console.ReadLine());


                socorro = classificar(carrocho[i]);
            }

            for (int i = 0; i < q; i++)
            {
                Console.WriteLine("\n{0}", classificar(carrocho[i]));
            }

        }

        static string classificar(Carro carrocho)
        {
            string ida, pote;

            if (carrocho.km <= 5000)
            {
                ida = "Novo";
            }

            else if (carrocho.km >= 3000)
            {
                ida = "Seminovo";
            }

            else
            {
                ida = "Velho";
            }

            //aqui começa o if da potencia

            if (carrocho.pot >= 200)
            {
                pote = "Potente";
            }

            else if (carrocho.pot < 200 && carrocho.pot >= 120)
            {
                pote = "Forte";
            }

            else
            {
                pote = "Popular";
            }

            return String.Format("{0},{1},{2}", carrocho.mol, ida, pote);

        }

        public static double TaxadeusoCarro(Carro c)
        {
            return c.km/(DateTime.Now.Year - c.AnoFabric);
        }

         public static void AtualizarkmCarro(Carro* c, double novokm)
        {
            c->km = novokm;
        }


    }
}