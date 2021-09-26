using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.Linq.Entities;
using Tp5.Linq.Logic;

namespace Tp5.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultasLogic consultaLogic = new ConsultasLogic();
            Console.WriteLine($"{consultaLogic.Consulta1().Address}-{consultaLogic.Consulta1().City}-{consultaLogic.Consulta1().CompanyName}-{consultaLogic.Consulta1().ContactName}-{consultaLogic.Consulta1().ContactTitle}-{consultaLogic.Consulta1().Country}");
            Console.WriteLine("Este fue el primer Customer encontrado");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();



            foreach (Products product in consultaLogic.Consulta2(0))
            {
                Console.WriteLine($"{product.ProductID}-{product.ProductName}");
            }
            Console.WriteLine("Esta fue la lista de productos sin stock");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();



            foreach (Products product in consultaLogic.Consulta3(0, 3))
            {
                Console.WriteLine($"{product.ProductID}-{product.ProductName}");
            }
            Console.WriteLine("Esta fue la lista de productos en stock que cuestan mas de 3");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();



            foreach (Customers costumer in consultaLogic.Consulta4("WA"))
            {
                Console.WriteLine($"{costumer.CompanyName}-{costumer.Address}-{costumer.City}-{costumer.Region}");
            }
            Console.WriteLine("Esta fue la lista de customers en la region WA");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();



            try
            {
                Products producto789 = consultaLogic.Consulta5(789);
                Console.WriteLine($"{producto789.ProductID}-{producto789.ProductName}-{producto789.UnitPrice}");
                Console.WriteLine("este fue el primer producto encontrado con el id 789");
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("No existe el producto con ese ID o es un producto nulo");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("presione enter para continuar");
            Console.ReadLine();




            List<Customers> customers = consultaLogic.Consulta6();
            foreach (Customers cust in customers)
            {
                Console.WriteLine(cust.CompanyName.ToUpper());
            }
            Console.WriteLine("Estos son los customers en mayusculas");
            Console.WriteLine("presione ENTER para continuar");
            Console.ReadLine();
            foreach (Customers cust in customers)
            {
                Console.WriteLine(cust.CompanyName.ToLower());
            }
            Console.WriteLine("Y estos son los customers en minusculas");
            Console.WriteLine("presione ENTER para continuar");
            Console.ReadLine();



            foreach (DtoCustomersOrders customerOrder in consultaLogic.Consulta7("WA", "1997-01-01"))
            {
                Console.WriteLine($"{customerOrder.CompanyName}-{customerOrder.OrderID}-{customerOrder.OrderDate}");
            }
            Console.WriteLine("Esta fue la lista de customers en la region WA que hicieron orders despues del 01-01-1997");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();




            foreach (Customers customer in consultaLogic.Consulta8("WA", 3))
            {
                Console.WriteLine($"{customer.CompanyName}");
            }
            Console.WriteLine("Esta fue la lista de los primeros 3 customers en la region WA");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();




            foreach (Products product in consultaLogic.Consulta9())
            {
                Console.WriteLine($"{product.ProductName}");
            }
            Console.WriteLine("Esta fue la lista de los productos ordenados por nombre");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();




            foreach (Products product in consultaLogic.Consulta10())
            {
                Console.WriteLine($"{product.ProductName}-{product.UnitsInStock}");
            }
            Console.WriteLine("Esta fue la lista de los productos ordenados por unidades en stock de mayor a menor");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();




            foreach (DtoProductsCategories productCategory in consultaLogic.Consulta11())
            {
                Console.WriteLine($"{productCategory.ProductName}-{productCategory.CategoryName}");
            }
            Console.WriteLine("Esta fue la lista de los productos con sus categorias asociadas");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();




            Console.WriteLine(consultaLogic.Consulta12().ProductName);
            Console.WriteLine("Este es el primer producto que aparece");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();



           
            



        }
    }
}
