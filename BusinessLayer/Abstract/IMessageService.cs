using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IMessageService
    {
        List<Message> GetAllInBox();
        List<Message> GetAllSendBox();
        void MesageAdd(Message message);
        void MesageDelete(Message message);
        void MesageUpdate(Message message);
        Message GetByID(int id);
    }
}
