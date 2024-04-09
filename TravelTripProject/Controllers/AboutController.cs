using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context(); //context sinifindan c nesnesi turettik.
        public ActionResult Index()
        {
            var degerler =c.Hakkimizdas.ToList(); //c nesnesi ile ulastigimiz tablolardan bir deger urettik.
            return View(degerler); // urettigimiz degeri view`da cagirdik.
        }
    }
}