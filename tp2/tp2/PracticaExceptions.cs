using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    public class PracticaExceptions
    {
        public static void DividirPorCeroException ()
        {
            try
            {
                Console.WriteLine("ingrese un número entero para dividir por cero");
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Por favor ingrese un numero entero");
                }
                numero.DividirPorCero();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            finally 
            {
                Console.WriteLine("La operación de división por cero terminó");
               
            }
        }

        public static void DividirException ()
        {
            try
            {
                Console.WriteLine("ingrese el dividendo");
                int dividendo = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el divisor");
                int divisor = int.Parse(Console.ReadLine());

                Console.WriteLine(string.Format("El resultado es {0}.", dividendo.Dividir(divisor)));

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Habiendo tantos numeros querés dividir por cero????");
                Console.WriteLine(ex.Message);

            }

            catch (FormatException ex)
            {
                Console.WriteLine("Seguro que ingresaste una letra o no ingresaste nada");
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                throw ex;
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("La operación terminó");
                
            }
        }
        
    }
}
