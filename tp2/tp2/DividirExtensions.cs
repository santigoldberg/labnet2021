using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    public static class DividirExtensions
    {
        public static int DividirPorCero (this int dividendo)
        {
            return dividendo / 0;
        }

        public static int Dividir(this int dividendo , int divisor)
        {
            return dividendo / divisor; 
        }
    }
}
