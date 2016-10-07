using proje_obs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proje_obs.Controllers
{
    public class idariController : Controller
    {
        // GET: idari
        public ActionResult Index()
        {
            if (Session["Id"] == null)
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
        public ActionResult Login(idari idari)
        {
            ObsContext ctx = new ObsContext();
            var ogr = ctx.idariler.FirstOrDefault(o => o.idariId == idari.idariId && o.Sifre == idari.Sifre);
            if (ogr != null)
            {
                Session.Add("Id", idari.idariId);
                Session.Add("Role", "idari");
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