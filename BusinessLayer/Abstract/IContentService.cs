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
        List<Content> GetList();
        List<Content> GetListByHeadingID(int id); //Idye göre bütün paramatreleri gönderir.
        void ContentAdd(Content content);
        Content GetByID(int id); //id ye işlem yap ve bul.Tek bir değer döndürür.
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}
