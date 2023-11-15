using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        CategoryValidator cv = new CategoryValidator();
        public ActionResult Index()
        {
            var values = cm.GetAll();
            return View(values);
        }
        [HttpGet]
        public ActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryAdd(Category category)
        {
            ValidationResult validationResult = cv.Validate(category);
            if (validationResult.IsValid)
            {
                cm.CategoryAdd(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
           
        }
        public ActionResult CategoryDelete(int id)
        {
            var values = cm.GetByID(id);
            cm.CategoryDelete(values);
           
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CategoryUpdate(int id)
        {
            var values = cm.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult CategoryUpdate(Category category)
        {
            cm.CategoryUpdate(category);
            

            return RedirectToAction("Index");
        }
    }
}