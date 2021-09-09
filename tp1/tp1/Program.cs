using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorOmnibus = 1;
            int contadorTaxis = 1;
            Console.WriteLine("ingrese la cantidad de Omnibus");
            int cantidadOmnibus;
            while (!int.TryParse(Console.ReadLine(), out cantidadOmnibus))
            {
                Console.WriteLine("Por favor ingrese un numero entero");
            }
            
            
            Console.WriteLine("ingrese la cantidad de Taxis");
            int cantidadTaxis;
            while (!int.TryParse(Console.ReadLine(), out cantidadTaxis))
            {
                Console.WriteLine("Por favor ingrese un numero entero");
            }
            



            List<TransportePublico> transportesPublicos = new List<TransportePublico>();
            
            while (cantidadOmnibus >= contadorOmnibus)
            {
                int pasajeros;
                Console.WriteLine("ingrese la cantidad de pasajeros del Omnibus " + contadorOmnibus);
                while (!int.TryParse(Console.ReadLine(), out pasajeros))
                {
                    Console.WriteLine("Por favor ingrese un numero entero");
                }
                transportesPublicos.Add(new Omnibus(pasajeros, contadorOmnibus));
                contadorOmnibus++;
            }

            while (cantidadTaxis >= contadorTaxis)
            {
                int pasajeros;
                Console.WriteLine("ingrese la cantidad de pasajeros del Taxi " + contadorTaxis);
                while (!int.TryParse(Console.ReadLine(), out pasajeros))
                {
                    Console.WriteLine("Por favor ingrese un numero entero");
                }
                transportesPublicos.Add(new Taxi(pasajeros,contadorTaxis));
                contadorTaxis++;
            }


            foreach (var item in transportesPublicos)
            {
                Console.WriteLine(item.Ordenar() +": "+item.pasajeros+" pasajeros");
            }

            Console.ReadLine();

        }
    }
}
