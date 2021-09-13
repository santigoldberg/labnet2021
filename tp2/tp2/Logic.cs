using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    public static class Logic
    {
        private static int MetodoConInteger (int parametro) 
        {
            return parametro;
        }
        public static void ThrowException()
        {
            MetodoConInteger(int.Parse("Esto es una cadena para que rompa"));
        }


        public static void ThrowCustomException()
        {
            throw new CustomException();
        }
    }
}
