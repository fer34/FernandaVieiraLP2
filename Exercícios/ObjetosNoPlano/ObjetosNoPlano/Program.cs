using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 500, L = 500;

            Console.Write("digite X inicial: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("digite Y inicial: ");
            int y = int.Parse(Console.ReadLine());

            Objeto2d obj = new Objeto2d();
            obj.x = x;
            obj.y = y;


            Console.Write("Digite comando: ");
            ConsoleKey comando = Console.ReadKey().Key;

            if (comando == ConsoleKey.RightArrow)
            {
                obj.AndarParaADireita();
                Console.WriteLine(obj.comando());

                Console.ReadLine();
            }
            else if (comando == ConsoleKey.LeftArrow)
            {
                obj.AndarParaAEsquerda();
                Console.WriteLine(obj.comando());
                Console.ReadLine();
            }
                
            
        }
    }
}
    

