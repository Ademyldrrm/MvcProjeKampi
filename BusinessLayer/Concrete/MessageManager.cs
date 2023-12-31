﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetAllInBox()
        {
           return _messageDal.List(x => x.SeceiverMail == "gizem@gmail.com");
        }
        public List<Message> GetAllSendBox()
        {
            return _messageDal.List(x => x.SenderMail == "gizem@gmail.com");
        }

        public Message GetByID(int id)
        {
            return _messageDal.Get(x => x.MessageID == id);
        }

        public void MesageAdd(Message message)
        {
            _messageDal.Insert(message);
        }

        public void MesageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void MesageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
