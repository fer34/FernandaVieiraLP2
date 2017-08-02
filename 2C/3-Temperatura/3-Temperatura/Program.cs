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
            string  tempdif;

            

            Console.WriteLine("Informe a tempeatura");
            tempc = double.Parse(Console.ReadLine());

            Conversor Conversão = new Conversor();

            Console.WriteLine("Digite para qual você quer converter");
            tempdif = Console.ReadLine();

            if (tempdif == "kelvin")
            {
               
            }
            else
            {

            }
            



        }
    }
}
