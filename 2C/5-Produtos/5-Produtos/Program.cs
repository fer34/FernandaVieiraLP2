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
            Produto p = new Produto(1, "cajuzinho 20g", 0.50);
            p.Reposiçao(40);
            p.Retirada(10);

            Console.WriteLine(p.Imprimir());
            //p.retirada 90      //I WANNA make love In THE CLUB TANANANA IN THE CLUB TURURU 'V' HEY TUTUTU HEY, HEY, HEY 'V'/
        }
    }
}
