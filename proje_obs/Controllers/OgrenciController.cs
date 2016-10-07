using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proje_obs.Models;

namespace proje_obs.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Index()
        {
            if(Session["Id"] == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Ogrenci ogrenci)
        {
            ObsContext ctx = new ObsContext();
            var ogr = ctx.Ogrenciler.FirstOrDefault(o => o.OgrenciId == ogrenci.OgrenciId && o.Sifre == ogrenci.Sifre);
            if(ogr != null)
            {
                Session.Add("Id", ogrenci.OgrenciId);
                Session.Add("Ad", ogr.Ad);
                Session.Add("Role", "Ogrenci");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}