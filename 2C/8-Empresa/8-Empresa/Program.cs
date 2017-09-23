using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargo;
            double sal;
            string reg, nome, cpf, mail;

            Console.WriteLine("Informe qual é o seu cargo:");
            Console.WriteLine("1-Gerente");
            Console.WriteLine("2-Empregado");
            Console.WriteLine("3-Terceirizado");

            cargo = int.Parse(Console.ReadLine());

            Console.Write("Informe seu número de registro: ");
            reg = Console.ReadLine();

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Informe seu CPF: ");
            cpf = Console.ReadLine();

            Console.Write("Informe seu email: ");
            mail = Console.ReadLine();

            Console.Write("Informe o seu salário: ");
            sal = double.Parse(Console.ReadLine());

            if (cargo == 1)
            {
                Gerente g = new Gerente(reg, nome, cpf, mail, sal);
                Console.WriteLine(g.Show(reg, nome, cpf, mail, sal));
            }
            else if (cargo == 2)
            {
                Empregado e = new Empregado(reg, nome, cpf, mail, sal);
                Console.WriteLine(e.Show(reg, nome, cpf, mail, sal));
            }
            else if (cargo == 3)
            {
                Terceirizado t = new Terceirizado(reg, nome, cpf, mail, sal);
                Console.WriteLine(t.Show(reg, nome, cpf, mail, sal));
            }



        }
    }
}
