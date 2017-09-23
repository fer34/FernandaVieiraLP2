using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresa
{
    class Gerente: Funcionario
    {
        public string setor { get; set; }
        public string bonus { get; set; }
        public Gerente(string reg, string nome, string cpf, string mail, double sal) : base(reg, nome, cpf, mail, sal)
        {

        }
        public string Show(string reg, string nome, string cpf, string mail, double sal)
        {
            return String.Format("Perfil Gerente:\nRegistro: {0}\nNome: {1}\nCPF: {2}\nEmail: {3}\nSalário: {4}", reg, nome, cpf, mail, sal);
        }
    
        
    }
}
