using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tp7.Data;
using Tp7.Entities;
using Tp7.Logic;

namespace Tp8.WebApi.Controllers
{
    public class CategoriesController : ApiController
    {
        CategoriesLogic categoriesLogic = new CategoriesLogic();
        // GET api/values
        public IEnumerable<Object> Get()
        {
           
            List<Categories> categories = categoriesLogic.GetAll();

             return categories.Select(s => new 
            {
                Id = s.CategoryID,
                CategoryName = s.CategoryName,
                Description = s.Description
            }).ToArray();

        }


        // POST api/values
        public void Post([FromBody] Categories categoryEntity)
        {
            categoriesLogic.Add(categoryEntity);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] Categories categoryEntity)
        {
            categoryEntity.CategoryID = id;
            categoriesLogic.Update(categoryEntity);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            categoriesLogic.Delete(id);
        }
    }
}
