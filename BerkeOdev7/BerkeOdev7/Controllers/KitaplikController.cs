using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BerkeOdev7.Controllers
{
    public class KitaplikController : Controller
    {
        // GET: Kitaplik
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Delete(int Id)
        {
            var Kitap = Models.KitapVeri.VeriListe.Where(x => x.Id == Id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Models.KitapVeri kitapVeri)
        {
            var Kitap = Models.KitapVeri.VeriListe.FirstOrDefault(x => x.Id == kitapVeri.Id);
            Models.KitapVeri.VeriListe.Remove(Kitap);
            return RedirectToAction("Sirala");
        }
        public ActionResult Edit (int Id)
        {
            var kitap = Models.KitapVeri.VeriListe.Where(x => x.Id == Id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Models.KitapVeri kitapVeri)
        {
            var kitap = Models.KitapVeri.VeriListe.FirstOrDefault(x => x.Id == kitapVeri.Id);
            kitap.Ad = kitapVeri.Ad;
            kitap.Yazar = kitapVeri.Yazar;
            kitap.YayinEvi = kitapVeri.YayinEvi;
            kitap.Fiyat = kitapVeri.Fiyat;
            kitap.BasimYil = kitapVeri.BasimYil;
            return RedirectToAction("Sirala");
        }
        public ActionResult Sirala()
        {
            return View(Models.KitapVeri.VeriListe);
        }
    }
}