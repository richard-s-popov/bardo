using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bardo.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sets()
        {
            return View();
        }

        public ActionResult Actions()
        {
            return View();
        }

        public ActionResult Rolls()
        {
            return View();
        }
    }
}
