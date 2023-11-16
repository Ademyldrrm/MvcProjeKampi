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
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager vm = new WriterManager( new EfWriterDal());
        public ActionResult Index()
        {
            var values=hm.GetAll();
            return View(values);
        }
        [HttpGet]
        public ActionResult HeadingAdd()
        {
            List<SelectListItem> valuecategory = (from x in cm.GetAll()
                                              select new SelectListItem
                                              {
                                                  Text=x.CategoryName,
                                                  Value=x.CategoryID.ToString()
                                              }).ToList();
            List<SelectListItem> valuewriter = (from x in vm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.WriterName,
                                                      Value = x.WriterID.ToString()
                                                  }).ToList();
            ViewBag.vlc=valuecategory;
            ViewBag.vlm = valuewriter;
            return View();
        }
        [HttpPost]
        public ActionResult HeadingAdd(Heading heading)
        {
            heading.HeadingDate=DateTime.Parse(DateTime.Now.ToString());
            hm.HeadingAdd(heading);
            return RedirectToAction("Index");
        }
        [HttpGet]
       public ActionResult HeadingUpdate(int id)
        {
            List<SelectListItem> valuecategory = (from x in cm.GetAll()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;
            var value = hm.GetByID(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult HeadingUpdate()
        {
            return View();
        }
    }
}