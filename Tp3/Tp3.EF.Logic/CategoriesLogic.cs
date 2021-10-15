using System;
using System.Collections.Generic;
using System.Linq;
using Tp7.Entities;

namespace Tp7.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        public void Add(Categories newCategory)
        {
            try
            {
                context.Categories.Add(newCategory);

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
                var categoryAEliminar = context.Categories.Find(id);
                context.Categories.Remove(categoryAEliminar);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public List<Categories> GetAll()
        {
            try
            {
                return context.Categories.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void Update(Categories category)
        {
            try
            {
                var categoryUpdate = context.Categories.Find(category.CategoryID);

                categoryUpdate.CategoryName = category.CategoryName;
                categoryUpdate.Description = category.Description;

                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public Categories GetById(int id)
        {
            return context.Categories.Find(id);
        }
        public int MaxID()
        {
            try
            {
                return context.Categories.Max(c => c.CategoryID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
             

        }
    }
}
