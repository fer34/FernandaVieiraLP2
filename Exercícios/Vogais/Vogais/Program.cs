using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;

            Console.WriteLine("Escreva uma palavra");
            frase = Console.ReadLine();

            int cont = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
                {
                    cont++;
                }
            }

            Console.WriteLine("A palavra tem {0} vogais", cont);
            Console.ReadKey();

        }
    }
}
