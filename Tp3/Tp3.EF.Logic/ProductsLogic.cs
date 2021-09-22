using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3.EF.Data;
using Tp3.EF.Entities;

namespace Tp3.EF.Logic
{
    public class ProductsLogic : BaseLogic , IABMLogic<Products>
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public void Add(Products newProduct)
        {
            context.Products.Add(newProduct);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productoAEliminar = context.Products.Find(id);
            context.Products.Remove(productoAEliminar);
            context.SaveChanges();
        }

        
        public void Update(Products product)
        {
            var productUpdate = context.Products.Find(product.ProductID);

            productUpdate.ProductName = product.ProductName;

            context.SaveChanges();
        }

        public int MaxID()
        {
            int maxId = 0;
            foreach (Products product in this.GetAll())
            {
                if (maxId < product.ProductID)
                {
                    maxId = product.ProductID;
                }
                
            }
            return maxId;

        }
        
    }
}
