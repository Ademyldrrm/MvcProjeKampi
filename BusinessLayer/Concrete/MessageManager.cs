using BusinessLayer.Abstract;
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

        public List<Message> GetAll()
        {
           return _messageDal.List(x => x.SeceiverMail == "admin@gmail.com");
        }

        public Message GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void MesageAdd(Message message)
        {
            throw new NotImplementedException();
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
