using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto c = new Produto(1, "presunto peça 100g", 5.00);
            c.reposi(200);
            c.reti(30);
            Console.WriteLine(c.Imprimir());

            Console.ReadLine();

        }
    }
}
