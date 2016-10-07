using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proje_obs.Models;

namespace proje_obs.Controllers
{
    public class TestModeController : Controller
    {
        // GET: GodMode
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOgrenci()
        {
            ObsContext ctx = new ObsContext();
            List<Ogrenci> ogrenciler = ctx.Ogrenciler.ToList();
            ctx.Dispose();
            return View(ogrenciler);
        }

        public ActionResult AddOgrenci()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOgrenci(Ogrenci ogrenci)
        {
            ObsContext ctx = new ObsContext();
            if (ctx.Ogrenciler.FirstOrDefault(o => o.OgrenciId == ogrenci.OgrenciId) == null)
            {
                ctx.Ogrenciler.Add(ogrenci);
            }
            ctx.SaveChanges();
            ctx.Dispose();
            return RedirectToAction("ListOgrenci");
        }

        public ActionResult OgrenciSil(int OgrenciId)
        {
            ObsContext ctx = new ObsContext();
            Ogrenci ogr = ctx.Ogrenciler.FirstOrDefault(o => o.OgrenciId == OgrenciId);
            if (ogr != null)
            {
                ctx.Ogrenciler.Remove(ogr);
            }
            ctx.SaveChanges();
            ctx.Dispose();
            return RedirectToAction("ListOgrenci");
        }

        public ActionResult ListOgretimElemani()
        {
            var ctx = new ObsContext();
            var ogretimElemanlari = ctx.OgretimElemanlari.ToList();
            ctx.Dispose();
            return View(ogretimElemanlari);
        }

        public ActionResult AddOgretimElemani()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOgretimElemani(OgretimElemani ogretimElemani)
        {
            ObsContext ctx = new ObsContext();
            if (ctx.OgretimElemanlari.FirstOrDefault(o => o.OgretimElemaniId == ogretimElemani.OgretimElemaniId) == null)
            {
                ctx.OgretimElemanlari.Add(ogretimElemani);

            }
            ctx.SaveChanges();
            ctx.Dispose();
            return RedirectToAction("ListOgretimElemani");
        }

        [HttpPost]
        public ActionResult OgretimElemaniSil(int OgretimElemaniId)
        {
            ObsContext ctx = new ObsContext();
            OgretimElemani ogr = ctx.OgretimElemanlari.FirstOrDefault(o => o.OgretimElemaniId == OgretimElemaniId);
            if (ogr != null)
            {
                ctx.OgretimElemanlari.Remove(ogr);
            }
            ctx.SaveChanges();
            ctx.Dispose();
            return RedirectToAction("ListOgretimElemani");
        }

        public ActionResult Listidari()
        {
            var ctx = new ObsContext();
            var ogretimElemanlari = ctx.idariler.ToList();
            ctx.Dispose();
            return View(ogretimElemanlari);
        }

        public ActionResult Addidari()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Addidari(idari ogretimElemani)
        {
            ObsContext ctx = new ObsContext();
            if (ctx.idariler.FirstOrDefault(o => o.idariId == ogretimElemani.idariId) == null)
            {
                ctx.idariler.Add(ogretimElemani);

            }
            ctx.SaveChanges();
            ctx.Dispose();
            return RedirectToAction("Listidari");
        }

        [HttpPost]
        public ActionResult idariSil(int idariId)
        {
            ObsContext ctx = new ObsContext();
            idari ogr = ctx.idariler.FirstOrDefault(o => o.idariId == idariId);
            if (ogr != null)
            {
                ctx.idariler.Remove(ogr);
            }
            ctx.SaveChanges();
            ctx.Dispose();
            return RedirectToAction("Listidari");
        }
    }
}