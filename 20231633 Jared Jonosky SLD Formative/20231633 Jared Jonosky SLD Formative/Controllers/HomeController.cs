using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20231633_Jared_Jonosky_SLD_Formative.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bobs Comics";

            return View();
        }
        public ActionResult Location()
        {
            ViewBag.Message = "Your Location page.";

            return View();
        }
        public ActionResult LatestNews()
        {


            return Redirect("https://www.marvel.com/comics/calendar?&offset=0&totalcount=20");
        }
        public ActionResult Favorites()
        {
            ViewBag.Message = "Your Favorites page.";

            return View();
        }




    }
}