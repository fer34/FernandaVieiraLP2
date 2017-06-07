using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjNoPlano
{
    class Obj
    {
        public int x = 0, y = 0;

        public void Direita()
        {
            x = x + 3;
        }

        public void Esquerda()
        {
            x = x - 3;
        }

        public void Cima()
        {
            y = y + 3;
        }

        public void Baixo()
        {
            y = y - 3;
        }

        public string Coordenadas()
        {
            return String.Format("({0},{1})", x, y);
        }
        
    }
}
