using System.Collections.Generic;
using System.Linq;
using Tp7.Entities;
using System;

namespace Tp7.Logic
{
    public class ProductsLogic : BaseLogic , IABMLogic<Products>
    {
        public List<Products> GetAll()
        {
            try
            {
                return context.Products.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void Add(Products newProduct)
        {
            try
            {
                context.Products.Add(newProduct);

                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void Delete(int id)
        {
            try
            {
                var productoAEliminar = context.Products.Find(id);
                context.Products.Remove(productoAEliminar);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        
        public void Update(Products product)
        {
            try
            {
                var productUpdate = context.Products.Find(product.ProductID);

                productUpdate.ProductName = product.ProductName;

                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public int MaxID()
        {
            try
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
            catch (Exception ex)
            {

                throw ex;
            }
            

        }
        
    }
}
