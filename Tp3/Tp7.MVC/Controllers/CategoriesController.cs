using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Tp7.Entities;
using Tp7.Logic;
using Tp7.MVC.Models;

namespace Tp7.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesLogic categoriesLogic = new CategoriesLogic();
        // GET: Categories
        public ActionResult Index()
        {
            var categoriesLogic = new CategoriesLogic();
            List<Categories> categories = categoriesLogic.GetAll();

            List<CategoriesView> categoryView = categories.Select(s => new CategoriesView 
            {
                Id = s.CategoryID,
                Name = s.CategoryName,
                Description = s.Description
            }).ToList();

            return View(categoryView);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CategoriesView categoryView)
        {
            try
            {
                Categories categoryEntity = new Categories { CategoryName = categoryView.Name, Description = categoryView.Description };
                
                categoriesLogic.Add(categoryEntity);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            categoriesLogic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}