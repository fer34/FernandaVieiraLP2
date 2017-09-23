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
            double m, km, mi;
            int entrada, opcao;

            Console.WriteLine("Escolha o número da opção que você deseja converter");
            Console.WriteLine("1-Massa");
            Console.WriteLine("2-Temperatura");
            Console.WriteLine("3-Distância");

            entrada = int.Parse(Console.ReadLine());

            if (entrada == 1)
            {
                Console.WriteLine("Deseja converter para:");
                Console.WriteLine("1-Quilos para Gramas");
                Console.WriteLine("2-Quilos para Toneladas");
                Console.WriteLine("3-Quilos para Libras");
                Console.WriteLine("4-O inverso da opção desejada");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    kg = double.Parse(Console.ReadLine());
                    Console.WriteLine(Converter.KGparaG(kg));
                }
                else if (opcao == 2)
                {
                    g = double.Parse(Console.ReadLine());
                    Console.WriteLine(Converter.KGparaTON(g));
                }
                else if (opcao == 3)
                {
                    g = double.Parse(Console.ReadLine());
                    Console.WriteLine(Converter.KGparaLB(g));
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Deseja converter de:");
                    Console.WriteLine("1-Gramas para Quilos");
                    Console.WriteLine("2-Toneladas para Quilos");
                    Console.WriteLine("3-Libra para Quilos");

                    opcao = int.Parse(Console.ReadLine());

                    if (opcao == 1)
                    {
                        g = double.Parse(Console.ReadLine());
                        Console.WriteLine(Converter.GparaKG(g));
                    }
                    else if (opcao == 2)
                    {
                        ton = double.Parse(Console.ReadLine());
                        Console.WriteLine(Converter.TONparaKG(ton));
                    }
                    else if (opcao == 3)
                    {
                        lib = double.Parse(Console.ReadLine());
                        Console.WriteLine(Converter.LBparaKG(lib));
                    }
                }
            }
            else if (entrada == 2)
            {
                Console.WriteLine("Deseja converter de:");
                Console.WriteLine("1-Celsius para Fahrenheit");
                Console.WriteLine("2-Fahrenheit para Kelvin");
                Console.WriteLine("3-Kelvin para Celsius");
                Console.WriteLine("4-O inverso das opções acima");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    c = double.Parse(Console.ReadLine());
                    Console.WriteLine(Converter.CparaF(c));
                }
                else if (opcao == 2)
                {
                    f = double.Parse(Console.ReadLine());
                    Console.WriteLine(Converter.FparaK(f));
                }
                else if (opcao == 3)
                {
                    k = double.Parse(Console.ReadLine());
                    Console.WriteLine(Converter.KparaC(k));
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Deseja converter de:");
                    Console.WriteLine("1-Fahrenheit para Celsius");
                    Console.WriteLine("2-Kelvin para Fahrenheit");
                    Console.WriteLine("3-Celsius para Kelvin");

                    opcao = int.Parse(Console.ReadLine());

                    if (opcao == 1)
                    {
                        f = double.Parse(Console.ReadLine());
                        Console.WriteLine(Converter.FparaC(f));
                    }
                    else if (opcao == 2)
                    {
                        k = double.Parse(Console.ReadLine());
                        Console.WriteLine(Converter.KparaF(k));
                    }
                    else if (opcao == 3)
                    {
                        c = double.Parse(Console.ReadLine());
                        Console.WriteLine(Converter.CparaK(c));
                    }
                }
            }
            else if (entrada == 3)
            {
                Console.WriteLine("Deseja converter de:");
                Console.WriteLine("1-Metros para Quilometros");
                Console.WriteLine("2-Quilometros para Milhas");
                Console.WriteLine("3-Metros para Pés");
                Console.WriteLine("4-Metros para Polegadas");
                Console.WriteLine("5-Polegadas para Pés");

                opcao = int.Parse(Console.ReadLine());







            }
        }
    }

