using System;
using System.Collections.Generic;
using System.Linq;
using TravelTripProject.Models.Siniflar;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace TravelTripProject.Controllers
{
    public class GirisYapController : Controller
    {
        Context c = new Context();

        // GET: GirisYap
        public ActionResult Index()
        {
            return View();
        }

        // GIRIS YAPMA ISLEMI
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin adm)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == adm.Kullanici && x.Sifre == adm.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
                Session["Kullanici"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        // CIKIS YAPMA ISLEMI
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");
        }
    }
}