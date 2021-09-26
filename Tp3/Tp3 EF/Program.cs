using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3.EF.Entities;
using Tp3.EF.Logic;

namespace Tp3.EF
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CategoriesLogic categoriesLogic = new CategoriesLogic();

                foreach (Categories category in categoriesLogic.GetAll())
                {
                    Console.WriteLine($"{category.CategoryID}-{category.CategoryName}");
                }

                Console.WriteLine("Esta fue la lista de categorias");
                Console.WriteLine();
                Console.WriteLine("Inserte el nombre de una nueva categoria");

                categoriesLogic.Add(new Categories
                {
                    CategoryID = categoriesLogic.MaxID() + 1,

                    CategoryName = Console.ReadLine()

                });

                foreach (Categories category in categoriesLogic.GetAll())
                {
                    Console.WriteLine($"{category.CategoryID}-{category.CategoryName}");
                }

                Console.WriteLine("Esta fue la lista de categorias actualizada");
                Console.WriteLine("ingrese el ID de la categoria a modificar");
                int idCategMod;
                while (!int.TryParse(Console.ReadLine(), out idCategMod))
                {
                    Console.WriteLine("Por favor ingrese un numero entero");
                }
                Console.WriteLine("ingrese el nuevo nombre de la categoria a modificar");

                categoriesLogic.Update(new Categories
                {
                    CategoryName = Console.ReadLine(),
                    CategoryID = idCategMod
                });
                foreach (Categories category in categoriesLogic.GetAll())
                {
                    Console.WriteLine($"{category.CategoryID}-{category.CategoryName}");
                }

                Console.WriteLine("Esta fue la lista de categorias actualizada");
                Console.WriteLine("ingrese el ID de la categoria a eliminar");

                int idCategDel;
                while (!int.TryParse(Console.ReadLine(), out idCategDel))
                {
                    Console.WriteLine("Por favor ingrese un numero entero");
                }
                categoriesLogic.Delete(idCategDel);
                foreach (Categories category in categoriesLogic.GetAll())
                {
                    Console.WriteLine($"{category.CategoryID}-{category.CategoryName}");
                }

                Console.WriteLine("Esta fue la lista de categorias actualizada");
                Console.WriteLine("Presione enter para ver la lista de Empleados");
                Console.ReadLine();








                EmployeesLogic employeesLogic = new EmployeesLogic();

                foreach (Employees employee in employeesLogic.GetAll())
                {
                    Console.WriteLine($"{employee.EmployeeID}-{employee.FirstName}-{employee.LastName}");
                }

                Console.WriteLine("Esta fue la lista de Empleados");
                Console.WriteLine();
                Console.WriteLine("Inserte el nombre de un nuevo empleado");
                string nombreNewEmp = Console.ReadLine();
                Console.WriteLine("Inserte el apellido de un nuevo empleado");
                string apellidoNewEmp = Console.ReadLine();

                employeesLogic.Add(new Employees
                {
                    EmployeeID = employeesLogic.MaxID() + 1,

                    FirstName = nombreNewEmp,

                    LastName = apellidoNewEmp

                });

                foreach (Employees employee in employeesLogic.GetAll())
                {
                    Console.WriteLine($"{employee.EmployeeID}-{employee.FirstName}-{employee.LastName}");
                }

                Console.WriteLine("Esta fue la lista de empleados actualizada");
                Console.WriteLine("ingrese el ID del empleado a modificar");
                int idEmpMod;
                while (!int.TryParse(Console.ReadLine(), out idEmpMod))
                {
                    Console.WriteLine("Por favor ingrese un numero entero");
                }
                Console.WriteLine("ingrese el nuevo nombre del empleado a modificar");
                string newFirstName = Console.ReadLine();
                Console.WriteLine("ingrese el nuevo apellido del empleado a modificar");
                string newLastName = Console.ReadLine();

                employeesLogic.Update(new Employees
                {
                    FirstName = newFirstName,
                    LastName = newLastName,
                    EmployeeID = idEmpMod
                });
                foreach (Employees employee in employeesLogic.GetAll())
                {
                    Console.WriteLine($"{employee.EmployeeID}-{employee.FirstName}-{employee.LastName}");
                }

                Console.WriteLine("Esta fue la lista de empleados actualizada");
                Console.WriteLine("ingrese el ID del empleado a eliminar");

                int idEmpDel;
                while (!int.TryParse(Console.ReadLine(), out idEmpDel))
                {
                    Console.WriteLine("Por favor ingrese un numero entero");
                }
                employeesLogic.Delete(idEmpDel);
                foreach (Employees employee in employeesLogic.GetAll())
                {
                    Console.WriteLine($"{employee.EmployeeID}-{employee.FirstName}-{employee.LastName}");
                }

                Console.WriteLine("Esta fue la lista de empleados actualizada");
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            



        }
    }
}
