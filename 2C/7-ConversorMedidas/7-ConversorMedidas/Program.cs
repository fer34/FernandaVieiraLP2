using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ConversorMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg, g, ton, lib;
            double c, k, f;
            double m, km, mi, ft;
            int entrada, opcao;

            Console.WriteLine("Escolha o número da opção que você deseja converter");
            Console.WriteLine("1-Massa");
            Console.WriteLine("2-Temperatura");
            Console.WriteLine("3-Distância");

            entrada = int.Parse(Console.ReadLine());

            if ( entrada == 1)
            {
                Console.WriteLine("Deseja converter para:");
                Console.WriteLine("1-Quilos para Gramas");
                Console.WriteLine("2-Quilos para Toneladas");
                Console.WriteLine("3-Quilos para Libras");
                Console.WriteLine("4-O inverso da opção desejada");

                entrada = int.Parse(Console.ReadLine());

                




            
        }
    }
}
