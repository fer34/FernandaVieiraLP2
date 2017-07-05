using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diadoano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o dia e o mês");
            string[] data = Console.ReadLine().Split(' ');

            int dia = int.Parse(data[0]);
            string mes = data[2];

            switch (mes)
            {
                case "Janeiro":
                    mes = "1";
                    break;

                case "Fevereiro":
                    mes = "2";
                    break;

                case "Março":
                    mes = "3";
                    break;

                case "Abril":
                    mes = "4";
                    break;

                case "Maio":
                    mes = "5";
                    break;

                case "Junho":
                    mes = "6";
                    break;

                case "Julho":
                    mes = "7";
                    break;

                case "Agosto":
                    mes = "8";
                    break;

                case "Setembro":
                    mes = "9";
                    break;

                case "Outubro":
                    mes = "10";
                    break;

                case "Novembro":
                    mes = "11";
                    break;

                case "Dezembro":
                    mes = "12";
                    break;
            }

            if (mes == "1")
            {
                dia = dia;
            }

            else if (mes == "2")
            {
                dia = dia + 31;
            }
            else if (mes == "3")
            {
                dia = dia + 59;
            }

            else if (mes == "4")
            {
                dia = dia + 90;
            }

            else if (mes == "5")
            {
                dia = dia + 120;
            }

            else if (mes == "6")
            {
                dia = dia + 151;
            }

            else if (mes == "7")
            {
                dia = dia + 181;
            }

            else if (mes == "8")
            {
                dia = dia + 212;
            }

            else if (mes == "9")
            {
                dia = dia + 243;
            }
            else if (mes == "10")
            {
                dia = dia + 273;
            }
            else if (mes == "11")
            {
                dia = dia + 304;
            }

            else if (mes == "12")
            {
                dia = dia + 334;
            }

            Console.WriteLine("{0} º dia do ano.", dia);
            Console.ReadKey();
        }
    }
}
