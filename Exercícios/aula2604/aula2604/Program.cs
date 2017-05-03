using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdv;

            Console.WriteLine("Informe o número de carros do galpão");
            qtdv = int.Parse(Console.ReadLine());

            int f = 0;
            string[] mode = new string[f];
            int[] km = new int[f];
            int[] pot = new int[f];
            string km2;

            for (int i = 0; i < qtdv; i++)
            {
                string pot2;
                Console.WriteLine("Informe o modelo do carro");
                mode[i] = Console.ReadLine();

                Console.WriteLine("Informe a quilometragem rodada do carro");
                km[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a potência do motor do carro");
                pot[i] = int.Parse(Console.ReadLine());

                if (km[i] <= 5000)
                {
                    km2 = "Novo";
                }
                else if (km[i] <= 30000)
                {
                    km2 = "Semi novo";
                }
                else
                {
                    km2 = "Velho";
                }

                // potência

                if (pot[i] >= 200)
                {
                    pot2 = "Potente";
                }

                else if (pot[i] < 200 && pot[i] >= 120)
                {
                    pot2 = "Forte";
                }
                else
                {
                    pot2 = "Popular";
                }


                Console.WriteLine("{0} - {1} - {2}", mode[i], km2, pot2);
                Console.ReadLine();


            }
        }
    }
}
