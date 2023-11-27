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
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager messageManager = new MessageManager( new EfMessageDal());
        MessageValidator validationRules = new MessageValidator();
        public ActionResult InBox()
        {
            
            var messageList = messageManager.GetAllInBox();
            return View(messageList);
        }
        public ActionResult SendBox()
        {
            var messageList = messageManager.GetAllSendBox();
            return View(messageList);
        }
        public ActionResult GetInMessageDetails(int id)
        {
            var values = messageManager.GetByID(id);
            return View(values);
        }
        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var values = messageManager.GetByID(id);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            ValidationResult result = validationRules.Validate(message);
            if (result.IsValid)
            {
                message.MessageDate =DateTime.Parse( DateTime.Now.ToShortDateString().ToString());
                messageManager.MesageAdd(message);
                return RedirectToAction("SendBox");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
          
        }
    }
}