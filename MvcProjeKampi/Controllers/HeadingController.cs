using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm =new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var headingValues = hm.GetList();
            return View(headingValues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text=x.CategoryName,
                                                      Value=x.CategoryID.ToString()
                                                  }).ToList();         //listenden şecilecek olan değer //valuemember=seçilmiş olan değerin IDsidir. DisplayMember(text) ise; seçilmiş olan değerin görünüm kısmıdır.yani kendisindir.


            List<SelectListItem> valuewriter = (from x in wm.GetList()
                                                select new SelectListItem 
                                                {
                                                    Text=x.WriterName + " " + x.WriterSurname,
                                                    Value=x.WriterID.ToString()
                                                }).ToList();
            ViewBag.vlc=valueCategory; //bu şekilde bunu view tarafına taşınır.
            ViewBag.vlm=valuewriter;
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p) 
        { 
            p.HeadingDate=DateTime.Parse(DateTime.Now.ToShortDateString()); //bugünün kısa tarihini yaz
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
    }
}