using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, cont0, contb, ast;
            int A, B, C, D, E;
            char resp;

            Console.WriteLine("informe o número de questões");
            N = Convert.ToInt32(Console.ReadLine());
 
            for(int i=0; i<N; i++)
            {
                A = Convert.ToInt32(Console.ReadLine());
                B = Convert.ToInt32(Console.ReadLine());
                C = Convert.ToInt32(Console.ReadLine());
                D = Convert.ToInt32(Console.ReadLine());
                E = Convert.ToInt32(Console.ReadLine());

                if(A <= 100) {resp = 'A'; cont0++;}
                else if (A >= 155) {contb++;} 
                else {ast++;}

                if(B <= 100) {resp = 'B'; cont0++;}
                else if (B >= 155) {contb++;} 
                else {ast++;}

                if(C <= 100) {resp = 'C'; cont0++;}
                else if (C >= 155) {contb++;} 
                else {ast++;}

                if(D <= 100) {resp = 'D'; cont0++;}
                else if (D >= 155) {contb++;} 
                else {ast++;}

                if(E <= 100) {resp = 'E'; cont0++;}
                else if (E >= 155) {contb++;} 
                else {ast++;}

                int(cont0 == 1 && contb == 0) {Console.WriteLine("{0}",resp);}
                else if()

           }

                








             
                
            
        }
    }
}
