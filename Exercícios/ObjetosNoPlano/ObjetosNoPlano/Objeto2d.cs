using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Objeto2d
    {
        public int x, y;
        

        public int AndarParaADireita()
        {
            x = x + 3;
            return x;
        }

        public int AndarParaAEsquerda()
        {
            x = x - 3;
            return x;
        }
              
         public string comando()
        {           
            return String.Format("[{0},{1}]", x, y);
        }
        


    }
}
