using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1 de la práctica");
            PracticaExceptions.DividirPorCeroException();
            Console.WriteLine("presiona una tecla para continuar...");
            Console.ReadLine();
            Console.WriteLine("Ejercicio 2 de la práctica");
            PracticaExceptions.DividirException();
            Console.WriteLine("presiona una tecla para continuar...");
            Console.ReadLine();
            Console.WriteLine("Ejercicio 3 de la práctica");
            try
            {
                Logic.ThrowException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se capturó una Excepción");
                Console.WriteLine(string.Format("El mensaje de la Excepción es: {0}", ex.Message));
                Console.WriteLine(string.Format("El tipo de Excepción es: {0}", ex.GetType()));
                Console.WriteLine("presiona una tecla para continuar...");
                Console.ReadLine();
            }

            Console.WriteLine("Ejercicio 4 de la práctica");
            try
            {
                Logic.ThrowCustomException();
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(string.Format("El mensaje de la Excepción es: {0}", ex.Message));
                Console.WriteLine(string.Format("El tipo de Excepción es: {0}", ex.GetType()));
                Console.ReadLine();
            }

        }
    }
}
