using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresa
{
    class Empregado: Funcionario
    {
        public int nRegistro { get; set; }
        public string CPF { get; set; }
        public double salário { get; set; }
        public int Nsetor { get; set; }
        public string nome { get; set; }
        public string email { get; set; }

    }
}
