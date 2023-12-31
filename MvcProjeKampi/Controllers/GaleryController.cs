﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class GaleryController : Controller
    {
        // GET: Galery
        ImageFileManager ImageFileManager = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var values = ImageFileManager.GetAll();
            return View(values);
        }
    }
}