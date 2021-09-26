using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3.EF.Entities;

namespace Tp3.EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
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

        public int MaxID()
        {
            int maxId = 0;
            foreach (Categories category in this.GetAll())
            {
                if (maxId < category.CategoryID)
                {
                    maxId = category.CategoryID;
                }

            }
            return maxId;

        }
    }
}
