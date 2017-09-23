using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ConversorMedidas
{
    class Converter
    {
        
        public static double gramas, kiloG; 
        public static double ton, kiloT; 
        public static double lb, kiloLB; 
        
        public static double cel, farC; 
        public static double far, kelF; 
        public static double kel, celK; 
        
        public static double mTOkm, kmTOm;
        public static double kmTOmph, mphTOkm;
        public static double mTOpes, pesTOm;
        public static double mTOpol, polTOm;
        public static double polTOpes, pesTOpol;

        public static string KGparaG(double kg)
        {
            gramas = kg / 10000;
            return String.Format("{0}g", gramas);
        }
        public static string GparaKG(double g)
        {
            kiloG = g / 1000.0;
            return String.Format("{0}kg", kiloG);
        }
        public static string KGparaTON(double kg)
        {
            ton = kg / 1000;
            return String.Format("{0}ton", ton);
        }
        public static string TONparaKG(double ton)
        {
            kiloT = ton * 1000;
            return String.Format("{0}kg", kiloT);
        }
        public static string KGparaLB(double kg)
        {
            lb = kg / 0.45359237;
            return String.Format("{0}lb", lb);
        }
        public static string LBparaKG(double lb)
        {
            kiloLB = lb * 0.45359237;
            return String.Format("{0}kg", kiloLB);
        }
        public static string CparaF(double c)
        {
            cel = (c * 9) / 5 + 32;
            return String.Format("{0}°c", cel);
        }
        public static string FparaC(double f)
        {
            farC = 5.0 / 9.0 * (f - 32);
            return String.Format("{0}°F", farC);
        }
        public static string FparaK(double f)
        {
            far = (f + 459.67) * (5.0 / 9.0);
            return String.Format("{0}K", far);
        }
        public static string KparaF(double k)
        {
            kelF = (k * 9.0 / 5.0) - 459.67;
            return String.Format("{0}°F", kelF);
        }
        public static string KparaC(double k)
        {
            return String.Format("{0}°C", k - 273.15);
        }
        public static string CparaK(double c)
        {
            return String.Format("{0}K", c + 273.15);
        }
    }
}
