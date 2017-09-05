using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempc;
            string  t;

            Conversor Conversão = new Conversor();

            Console.WriteLine("Informe a tempeatura");
            tempc = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite para qual você quer converter: F de Fahrenheit ou K de Kelvin");
            t = Console.ReadLine();

            tempc.c = cel;

            if (t == "F")
            {
                Console.WriteLine("\n" + tempc.paraF(tempc.f));
            }
            else
            {
                Console.WriteLine("\n" + tempc.paraK(tempc.k));
            }
            



        }
    }
}
