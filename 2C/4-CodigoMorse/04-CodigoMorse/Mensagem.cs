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

            public string Decodificar(string palavra)
            {
                Dictionary<string, string> morseCode = new Dictionary<string, string>

                    {

                            {".-   ", "a"}, { "-... ", "b"}, {"-.-. ", "c"}, {"-..  ", "d"}, 

                            {".    ", "e"}, {"..-. ", "f"}, {"--.  ", "g"}, {".... ", "h"},

                            {"..   ", "i"}, {".--- ", "j"}, {"-.-  ", "k"}, {".-.. ", "l"},

                            {"--   ", "m"}, {"-.   ", "n"}, {"---  ", "o"}, {".--. ", "p"}, 

                            {"--.- ", "q"}, {".-.  ", "r"}, {"...  ", "s"}, {"-    ", "t"}, 

                            {"..-  ", "u"}, {"...- ", "v"}, {".--  ", "w"}, {"-..- ", "x"}, 

                            {"-.-- ", "y"}, {"--.. ", "z"},
                    };

                for (int i = 0; i < palavra.Length; i++)
                {
                    char c = palavra[i];

                    if (morseCode.ContainsKey(c)) { return morseCode[c]; }
                }
            }


                    
        }
    }
}
