using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj_no_plano_2_parte
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 800, l = 600, x, y;

            Console.WriteLine("Escreva X");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva Y");
            y = int.Parse(Console.ReadLine());

            Obj obj = new Obj();

            obj.x = x;
            obj.y = y;

            do
            {
                Console.WriteLine("Insira o comando: ");
                ConsoleKey comando = Console.ReadKey().Key;

                if (comando == ConsoleKey.RightArrow)
                {
                    obj.Direita();
                }

                else if (comando == ConsoleKey.LeftArrow)
                {
                    obj.Esquerda();
                }

                else if (comando == ConsoleKey.UpArrow)
                {
                    obj.Cima();
                }

                else
                {
                    obj.Baixo();
                }

                Console.WriteLine(obj.Coordenadas());
            }

            while (true);
        }
    }
}
