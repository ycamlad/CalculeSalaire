using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeSalaire
{
    public static class Calcul
    {

        public static double impotFed(double brut)
        {
            double impot = 0;
            if (brut <= 35000)
            {
                impot = brut * 0.16;
            }
            else
            {
                impot = (35000 * 0.16) + (brut - 35000) * 0.22;
            }

            return impot;
        }

        public static double impotProv(double brut)
        {
            double impot;
            if (brut <= 35000)
            {
                impot = brut * 0.0605;
            }
            else
            {
                impot = (35000 * 0.0605) + (brut - 35000) * 0.0725;
            }

            return impot;
        }

        public static double assurance(double brut)
        {
            return brut * 0.0277;
        }

        public static double RRC(double brut)
        {
            return brut * 0.0495;
        }
    }
}
