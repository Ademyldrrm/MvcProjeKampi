using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager abm = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var values = abm.GetAll();
            return View(values);
        }
        [HttpGet]
        public ActionResult AboutAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AboutAdd(About about)
        {
            abm.AboutAdd(about);
            return RedirectToAction("Index");
        }
        public PartialViewResult AboutAddPartial()
        {
            return PartialView();
        }
    }
}