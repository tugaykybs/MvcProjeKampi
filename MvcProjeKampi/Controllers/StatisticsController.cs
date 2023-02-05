using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
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
    public class StatisticsController : Controller
    {
        // GET: Statistics
        Context c = new Context();
        public ActionResult Index()
        {
           

            var deger1 = c.Categories.Count().ToString(); 
            ViewBag.d1 = deger1;

            var deger2 = c.Headings.Where(x => x.CategoryID == 9).Count().ToString();  
            ViewBag.d2 = deger2;

            var deger3 = c.Writers.Where(x => x.WriterName.Contains("a")).ToList().Count();
            ViewBag.d3 = deger3;

            var deger4 = c.Categories.Where(u => u.CategoryID == (c.Headings.GroupBy(x => x.CategoryID)).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault()).Select(k => k.CategoryName).FirstOrDefault();  
            ViewBag.d4 = deger4;

            int degertrue = c.Categories.Where(x => x.CategoryStatus == true).Count();
            int degerfalse = c.Categories.Where(x => x.CategoryStatus == false).Count();
            var deger5 = degertrue - degerfalse;
            ViewBag.d5 = deger5;
            return View();
        }
    }
}

//count==kaç adate var gibi

//where==ama demek

//select=seçmene yarıyor, Key=seçtiğin alanı seç ve isimlendir.  , groupby=gruplama yapıyor, OrderByDescending=sirasına göre sıralama