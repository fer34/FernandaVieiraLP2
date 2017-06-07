using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 800, l = 600, x, y,raio;

            Console.WriteLine("Escreva A");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva L");
            l = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva X");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva Y");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o raio");
            raio = int.Parse(Console.ReadLine());
            
            Circulo obj = new Circulo();
            
            obj.raio = raio;
            obj.x = x;
            obj.y = y;

            Console.WriteLine("Insira o comando: ");
            ConsoleKey comando = Console.ReadKey().Key;

            do
            {
                
                
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

                else if (comando == ConsoleKey.DownArrow)
                {
                    obj.Baixo();
                }
                else if (comando == ConsoleKey.Escape)
                {
                    break;
                }
                
                if (obj.x > 800)
                {
                    obj.x = 800;
                }

                else if (obj.y > 600)
                {
                    obj.y = 600;
                }
                              
                
                Console.WriteLine(obj.Coordenadas());
                }

            while (true);
        }
    }
}
