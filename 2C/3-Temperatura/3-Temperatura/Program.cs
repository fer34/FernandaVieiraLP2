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
            double cel = 0;
            string t;

            Conversor temp = new Conversor();


            Console.WriteLine("Informe a temperatura desejada para conversão:F para fahrenheit ou K para kelvin");
            t = Console.ReadLine();

            Console.WriteLine("Informe a temperatura em celsius");
            cel = double.Parse(Console.ReadLine());

            temp.cels = cel;

            if (t == "F")
            {
                Console.WriteLine("\n" + temp.paraF(temp.far));
            }

            else
            {
                Console.WriteLine("\n" + temp.paraK(temp.kel));
            }




        }
    }
}
