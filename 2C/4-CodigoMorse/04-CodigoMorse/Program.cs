using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string palavra, escolha;

            Console.WriteLine("Escreva o que desejar");
            palavra = Console.ReadLine();

            Console.WriteLine("O que deseja fazer com seu texto? \n1-Codificar \n2-Decodificar \n3-Transmitir \n4-Sair");
            escolha = Console.ReadLine();

            mensagem cod = new mensagem();

            do
            {
                if (escolha == "1")
                {
                    Console.WriteLine(morse.Codificar());
                }
                if (escolha == "2")
                {
                    Console.WriteLine(morse.Decodificar());
                }
                if (escolha == "3")
                {
                    Console.WriteLine(morse.Transmitir());
                }

            }
            while (escolha != "4");


            


        }
    }
}
