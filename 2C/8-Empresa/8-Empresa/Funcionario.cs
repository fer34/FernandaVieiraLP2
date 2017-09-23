using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresa
{
    class Funcionario
    {
        public string reg { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string mail { get; set; }
        public double sal { get; set; }
        public Funcionario(string reg, string nome, string cpf, string mail, double sal)
        {
            this.reg = reg;
            this.nome = nome;
            this.cpf = cpf;
            this.mail = mail;
            this.sal = sal;
        }




    }
}
