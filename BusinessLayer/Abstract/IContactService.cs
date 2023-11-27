using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface IContactService
    {
        List<Contact> GetAll();
        void ContactyAdd(Contact contact);
        void ContactDelete(Contact contact);
        void ContactyUpdate(Contact contact);
        Contact GetByID(int id);
    }
}
