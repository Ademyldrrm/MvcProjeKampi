using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetAll();
        List<Content> GetListByID(int id);
        void ContentAdd(Content content);
        void ContendDelete(Content content);
        void ContendUpdate(Content content);
        Content GetByID(int id);
    }
}
