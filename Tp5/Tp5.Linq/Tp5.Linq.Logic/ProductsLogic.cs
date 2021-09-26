using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.Linq.Data;
using Tp5.Linq.Entities;

namespace Tp5.Linq.Logic
{
    public class ProductsLogic : BaseLogic , IABMLogic<Products>
    {
        public void Add(Products newProduct)
        {
            context.Products.Add(newProduct);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productAEliminar = context.Products.First(r => r.ProductID == id);
        }

        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public void Update(Products product)
        {
            var productUpdate = context.Products.First(p => p.ProductID == product.ProductID);

            productUpdate.ProductName = product.ProductName;

            context.SaveChanges();
        }
    }
}
