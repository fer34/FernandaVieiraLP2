using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj_no_plano_2_parte
{
    class Obj2
    {
        public int x = 0, y = 0, raio;

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

        public string circulo()
        {
            int raio, r, g, b;

            Console.WriteLine("Qual o raio? (em pixels)");
            raio = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o quantidade de R");
            r = int.Parse(Console.ReadLine());


            Console.WriteLine("Insira o quantidade de G");
            g = int.Parse(Console.ReadLine());


            Console.WriteLine("Insira o quantidade de B");
            b = int.Parse(Console.ReadLine());

            return String.Format("O raio é de {0} pixels.Círculo contém {1} de vermelho,{2} de verde e {3} de azul", raio, r, g, b);
        }

        public string Coordenadas()
        {
            return String.Format("({0},{1})", x, y);
        }
    }
}
