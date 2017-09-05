using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Temperatura
{
    class Conversor
    {
        public double c, f, k;

        public double paraF(double cel)
        {
            return f = (c * 1.8) + 32;
        }
        public double paraK(double cel)
        {
            return k = c - 273;
        }

    }
}
