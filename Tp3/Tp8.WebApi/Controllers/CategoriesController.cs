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
            try
            {
                List<Categories> categories = categoriesLogic.GetAll();

                return categories.Select(s => new
                {
                    Id = s.CategoryID,
                    CategoryName = s.CategoryName,
                    Description = s.Description
                }).ToArray();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
            

        }


        // POST api/values
        public void Post([FromBody] Categories categoryEntity)
        {
            try
            {
                categoriesLogic.Add(categoryEntity);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] Categories categoryEntity)
        {
            try
            {
                categoryEntity.CategoryID = id;
                categoriesLogic.Update(categoryEntity);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            try
            {
                categoriesLogic.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
