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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal) //generate constructor (yapıcı metot yapılır).
        {
            _contentDal = contentDal;
        }

        public void ContentAdd(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            throw new NotImplementedException();  //bir parametre bağlı olarak listeleme yapmak için kullanılır.
        }

        public List<Content> GetListByHeadingID(int id)
        {
            return _contentDal.List(x=>x.HeadingID==id);  //heading ID eşit eşit dışarıdan gönderdiğim idlerin listesini gönderir.
        }
    }
}
