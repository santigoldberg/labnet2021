using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.Linq.Entities;

namespace Tp5.Linq.Logic
{
    public class ConsultasLogic : BaseLogic
    {
        public Customers Consulta1()
        {
            var customerObject = context.Customers.First(c => c.CustomerID.Contains(""));
            return customerObject;
        }

        public List<Products> Consulta2(int stock)
        {
            return context.Products.Where(p => p.UnitsInStock == stock).ToList();
        }

        public List<Products> Consulta3(int stock , decimal precio)
        {
            var query = from product in context.Products
                        where product.UnitsInStock > stock && product.UnitPrice > precio
                        select product;

            return query.ToList();
        }

        public List<Customers> Consulta4(string reg)
        {
            var query = from customer in context.Customers
                        where customer.Region == reg
                        select customer;
            return query.ToList();
        }

        public Products Consulta5(int id)
        {
            var productObject = context.Products.FirstOrDefault(p => p.ProductID.Equals(id));
            return productObject;
        }

        public List<Customers> Consulta6()
        {
            var query = from customer in context.Customers
                        select customer;
            return query.ToList();
        }

        public List<DtoCustomersOrders> Consulta7(string reg, string fechaorden)
        {
            DateTime fecha = Convert.ToDateTime(fechaorden);
            var query = from customer in context.Customers
                        join order in context.Orders
                        on customer.CustomerID equals order.CustomerID
                        where customer.Region == reg && order.OrderDate > fecha
                        select new DtoCustomersOrders
                        { 
                            CompanyName = customer.CompanyName,
                            OrderID = order.OrderID,
                            OrderDate = order.OrderDate
                        };                        
            return query.ToList();
        }


        public List<Customers> Consulta8(string reg, int limit)
        {
            return context.Customers.Where(c => c.Region == reg).Take(limit).ToList();            
        }


        public List<Products> Consulta9()
        {
            var query = from products in context.Products
                        orderby products.ProductName
                        select products;
            
            return query.ToList();
        }

        public List<Products> Consulta10()
        {
            var query = from products in context.Products
                        orderby products.UnitsInStock descending
                        select products;

            return query.ToList();
        }



        public List<DtoProductsCategories> Consulta11()
        {
            var query = from products in context.Products
                        join categories in context.Categories
                        on products.CategoryID equals categories.CategoryID
                        select new DtoProductsCategories
                        {
                            ProductName = products.ProductName,
                            CategoryName = categories.CategoryName
                        };
            return query.ToList();
            
        }


        public Products Consulta12()
        {
            var productObject = context.Products.First();
            return productObject;
        }

        // La consulta 13 no puedo pasar la query a lista. 
        //public IEnumerable Consulta13()
        //{
        //    var query = from customer in context.Customers
        //                join order in context.Orders
        //                on customer.CustomerID equals order.CustomerID
        //                group customer by new { customer.CompanyName } into grupo
        //                select new
        //                {
        //                    CompanyName = grupo.Key.CompanyName.ToString(),
        //                    CountOrder = Convert.ToInt16(grupo.Count())
        //                };
        //    return query;

        //}

    }
}
