using System.Collections.Generic;
using System.Linq;
using Tp7.Entities;

namespace Tp7.Logic
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
            categoryUpdate.Description = category.Description;

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
