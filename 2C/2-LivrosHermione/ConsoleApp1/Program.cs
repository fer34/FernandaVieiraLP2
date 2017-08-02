using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double ph, hlpd, pd, tleitura = 0, lertodos = 0;
            int qtd, na1 = 0;

            Console.WriteLine("Informe a quantidade de livros:");
            qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe quantas páginas você lê por hora");
            ph = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantia de horas que você lê por dia");
            hlpd = double.Parse(Console.ReadLine());

            Livro[] book = new Livro[qtd];

            string[] nau = new string[qtd];

            pd = ph * hlpd;

            for (int i = 0; i < qtd; i++)
            {
                book[i] = new Livro();

                Console.WriteLine("Informe o título do {0}º livro:", i + 1);
                book[i].titulo = Console.ReadLine();

                Console.WriteLine("Páginas que o {0}º livro tem:", i + 1);
                book[i].pags = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o tempo restante para devolução em dias do {0}º livro", i + 1);
                book[i].devolver = double.Parse(Console.ReadLine());

                tleitura = book[i].pags / pd; 

                lertodos = lertodos + tleitura; 

                Console.WriteLine("Vai levar {0} dia(s) para ler o livro '{1}'", tleitura, book[i].titulo);

                if (tleitura > book[i].devolver)
                {
                    nau[na1] = book[i].titulo;
                    na1++;
                }
            }
            Console.WriteLine("Vai levar {0} dias para você ler todos os livros", lertodos);

            if (na1 > 0)
            {
                for (int i = 0; i < na1; i++)
                {
                    Console.WriteLine("Livro(s) impossíveis de serem lidos:");
                    Console.WriteLine(nau[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
