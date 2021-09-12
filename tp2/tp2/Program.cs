using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1 de la práctica");
            PracticaExceptions.DividirPorCeroException();
            Console.WriteLine();
            Console.WriteLine("Ejercicio 2 de la práctica");
            PracticaExceptions.DividirException();
            
        }
    }
}
