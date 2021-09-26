using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.Linq.Entities;

namespace Tp5.Linq.Logic
{
    public class CategoriesLogic : BaseLogic , IABMLogic<Categories>
    {
        public void Add(Categories newCategory)
        {
            context.Categories.Add(newCategory);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var categoryAEliminar = context.Categories.Find(id);
            context.Categories.Remove(categoryAEliminar);
            context.SaveChanges();
        }

        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Update(Categories category)
        {
            var categoryUpdate = context.Categories.Find(category.CategoryID);

            categoryUpdate.CategoryName = category.CategoryName;

            context.SaveChanges();
        }

    }
}
