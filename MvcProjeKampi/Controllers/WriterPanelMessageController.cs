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
    public class WriterPanelMessageController : Controller
    {
        // GET: WriterPanelMessage
        MessageManager messageManager = new MessageManager(new EfMessageDal());
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
        public PartialViewResult MessageListMenu()
		{
            return PartialView();
		}
    }
}