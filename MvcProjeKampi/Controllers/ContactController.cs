using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager contactManager = new ContactManager(new EfContactDal());
        ContactValidator validationRules = new ContactValidator();
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        public ActionResult Index()
        {
            var values = contactManager.GetAll();
            return View(values);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = contactManager.GetByID(id);
            return View(contactvalues);
        }
        public PartialViewResult MessageListMenu()
        {
            ViewBag.v = messageManager.GetAllInBox().Count();
            ViewBag.v1 = messageManager.GetAllSendBox().Count();
            ViewBag.v2 = contactManager.GetAll().Count();
            return PartialView();
        }
    }
}