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

            Obj2 obj = new Obj2();

            obj.x = x;
            obj.y = y;

            Console.WriteLine("Insira o comando: ");

            do
            {
                
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

                if (obj.x < 0)
                {
                    obj.x = 0;
                }

                if (obj.y > 600)
                {
                    obj.y = 600;
                }

                if (obj.y < 0)
                {
                    obj.y = 0;
                }

                Console.WriteLine(obj.Coordenadas());
            }

            while (true);

            Console.WriteLine(obj.circulo());

            Bitmap myBitmap = new Bitmap(@"C:\meusdeuses.jpg");
            Graphics g = Graphics.FromImage(myBitmap);

        }
    }
}
