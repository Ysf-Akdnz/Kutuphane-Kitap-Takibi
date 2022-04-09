using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using deneme2.Models.Entity;

namespace deneme2.Controllers
{
    public class KitaplarController : Controller
    {
        // GET: Kitaplar
        kitaplarEntities ktp = new kitaplarEntities();
        public ActionResult Index(string arama)
        {
            var model = from m in ktp.Kitaplar select m;
            if(!string.IsNullOrEmpty(arama))
            {
                model = model.Where(d => d.Kitap_adi.Contains(arama) || d.Yazar.Contains(arama) || d.Turu.Contains(arama));
            }
            return View(model.ToList());
            //var model = ktp.Kitaplar.ToList();
            //return View(model);
        }
    }
}