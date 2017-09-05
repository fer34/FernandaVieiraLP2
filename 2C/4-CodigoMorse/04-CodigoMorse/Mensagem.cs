using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CodigoMorse
{
    class Mensagem
    {
        public string palavra;

        public string Codificar(string palavra)
        {
            Dictionary<char, String> morseCode = new Dictionary<char, string>()
             {
                 {'A' , ".-"},
                 {'B' , "-..."},
                 {'C' , "-.-."},
                 {'D' , "-.."},
                 {'E' , "."},
                 {'F' , "..-."},
                 {'G' , "--."},
                 {'H' , "...."},
                 {'I' , ".."},
                 {'J' , ".---"},
                 {'K' , "-.-"},
                 {'L' , ".-.."},
                 {'M' , "--"},
                 {'N' , "-."},
                 {'O' , "---"},
                 {'P' , ".--."},
                 {'Q' , "--.-"},
                 {'R' , ".-."},
                 {'S' , ".-."},
                 {'T' , "-"},
                 {'U' , "..-"},
                 {'V' , "...-"},
                 {'W' , ".--"},
                 {'X' , "-..-"},
                 {'Y' , "-.--"},
                 {'Z' , "--.."},
             };

            for (int i = 0; i < palavra.Length; i++)
            {
                char c = palavra[i];

                if (morseCode.ContainsKey(c)) { return morseCode[c]; }
            }
        }
    }
}
