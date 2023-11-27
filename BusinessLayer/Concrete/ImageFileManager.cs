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
    public class ImageFileManager : IImageFileService
    {
        IImageDal _ımageDal;

        public ImageFileManager(IImageDal ımageDal)
        {
            _ımageDal = ımageDal;
        }

        public List<ImageFile> GetAll()
        {
            return _ımageDal.List();
        }
    }
}
