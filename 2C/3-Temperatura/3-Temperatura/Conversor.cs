using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Temperatura
{
    class Conversor
    {
        public double cels, far, kel;

        public double paraF(double cel)
        {
            return far = (cels * 1.8) + 32;
        }

        public double paraK(double cel)
        {
            return kel = cels + 273;
        }

    }
}
